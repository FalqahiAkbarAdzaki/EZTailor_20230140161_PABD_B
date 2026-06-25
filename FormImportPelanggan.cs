using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
 
namespace EZTailor
{
    /// <summary>
    /// Form Import Pelanggan dari Excel
    /// Fitur UCP3: Import dari Excel → Database
    /// Data yang diimport: Nama, No HP, Alamat
    /// </summary>
    public partial class FormImportPelanggan : Form
    {
        private readonly string connectionString =
            "Data Source=LAPTOPAQA\\AQASAMA;Initial Catalog=TailorDB;Integrated Security=True";

        private DataTable dtPreview = new DataTable();

        public FormImportPelanggan()
        {
            InitializeComponent();
        }

        private void FormImportPelanggan_Load(object sender, EventArgs e)
        {
            // Setup kolom preview
            dtPreview.Columns.Add("Nama");
            dtPreview.Columns.Add("No HP");
            dtPreview.Columns.Add("Alamat");
            dtPreview.Columns.Add("Status");

            dgvPreview.DataSource = dtPreview;
            lblStatus.Text = "Belum ada file dipilih";
            btnImport.Enabled = false;
        }

        // ----------------------------------------
        // PILIH FILE EXCEL
        // ----------------------------------------
        private void btnPilihFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Pilih File Excel Data Pelanggan",
                Filter = "Excel Files (*.xlsx)|*.xlsx"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            txtFilePath.Text = ofd.FileName;
            PreviewExcel(ofd.FileName);
        }

        private void PreviewExcel(string filePath)
        {
            dtPreview.Rows.Clear();
            lblStatus.Text = "Membaca file...";

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var ws = workbook.Worksheet(1);
                    int lastRow = ws.LastRowUsed().RowNumber();

                    // Validasi header
                    string h1 = ws.Cell(1, 1).GetString().Trim().ToLower();
                    string h2 = ws.Cell(1, 2).GetString().Trim().ToLower();
                    string h3 = ws.Cell(1, 3).GetString().Trim().ToLower();

                    if (!h1.Contains("nama") || !h2.Contains("hp") || !h3.Contains("alamat"))
                    {
                        MessageBox.Show(
                            "Format Excel tidak sesuai!\n\nFormat yang benar:\n" +
                            "Kolom A: Nama\nKolom B: No HP\nKolom C: Alamat",
                            "Format Salah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    for (int row = 2; row <= lastRow; row++)
                    {
                        string nama = ws.Cell(row, 1).GetString().Trim();
                        string hp = ws.Cell(row, 2).GetString().Trim();
                        string alamat = ws.Cell(row, 3).GetString().Trim();

                        string status = ValidasiData(nama, hp, alamat);
                        dtPreview.Rows.Add(nama, hp, alamat, status);
                    }

                    lblStatus.Text = $"Preview: {lastRow - 1} data ditemukan";
                    btnImport.Enabled = true;

                    // Warna baris berdasarkan status
                    foreach (DataGridViewRow dgvRow in dgvPreview.Rows)
                    {
                        if (dgvRow.Cells["Status"].Value?.ToString() == "OK")
                            dgvRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        else
                            dgvRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca file: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Gagal membaca file";
            }
        }

        private string ValidasiData(string nama, string hp, string alamat)
        {
            if (string.IsNullOrWhiteSpace(nama) || nama.Length < 3)
                return "ERROR: Nama minimal 3 karakter";
            if (string.IsNullOrWhiteSpace(hp) || hp.Length < 10)
                return "ERROR: No HP minimal 10 digit";
            if (string.IsNullOrWhiteSpace(alamat) || alamat.Length < 5)
                return "ERROR: Alamat minimal 5 karakter";
            return "OK";
        }

        // ----------------------------------------
        // DOWNLOAD TEMPLATE EXCEL
        // ----------------------------------------
        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Simpan Template Excel",
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                FileName = "Template_Import_Pelanggan.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Data Pelanggan");

                    // Header
                    ws.Cell(1, 1).Value = "Nama";
                    ws.Cell(1, 2).Value = "No HP";
                    ws.Cell(1, 3).Value = "Alamat";

                    // Format header
                    var headerRange = ws.Range(1, 1, 1, 3);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                    headerRange.Style.Font.FontColor = XLColor.White;

                    // Contoh data
                    ws.Cell(2, 1).Value = "Andi Wijaya";
                    ws.Cell(2, 2).Value = "081234567890";
                    ws.Cell(2, 3).Value = "Jl. Merpati No.12, Yogyakarta";

                    ws.Cell(3, 1).Value = "Siti Rahayu";
                    ws.Cell(3, 2).Value = "082345678901";
                    ws.Cell(3, 3).Value = "Jl. Anggrek No.5, Bantul";

                    // Auto-fit kolom
                    ws.Columns().AdjustToContents();

                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Template berhasil disimpan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuat template: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------
        // IMPORT KE DATABASE
        // ----------------------------------------
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dtPreview.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diimport!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int berhasil = 0, gagal = 0, dilewati = 0;
            progressBar1.Maximum = dtPreview.Rows.Count;
            progressBar1.Value = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataRow row in dtPreview.Rows)
                    {
                        string status = row["Status"].ToString();
                        if (status != "OK")
                        {
                            gagal++;
                            progressBar1.Value++;
                            continue;
                        }

                        string nama = row["Nama"].ToString();
                        string hp = row["No HP"].ToString();
                        string alamat = row["Alamat"].ToString();

                        // Cek duplikat
                        SqlCommand cekCmd = new SqlCommand(
                            "SELECT COUNT(*) FROM Pelanggan WHERE no_hp=@hp", conn);
                        cekCmd.Parameters.AddWithValue("@hp", hp);
                        int count = (int)cekCmd.ExecuteScalar();

                        if (count > 0 && !chkTimpaDuplikat.Checked)
                        {
                            dilewati++;
                            progressBar1.Value++;
                            continue;
                        }

                        try
                        {
                            SqlCommand cmd = new SqlCommand("sp_ImportPelangganBulk", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@nama", nama);
                            cmd.Parameters.AddWithValue("@hp", hp);
                            cmd.Parameters.AddWithValue("@alamat", alamat);
                            cmd.ExecuteNonQuery();
                            berhasil++;
                        }
                        catch
                        {
                            gagal++;
                        }

                        progressBar1.Value++;
                    }
                }

                MessageBox.Show(
                    $"Import selesai!\n" +
                    $"✓ Berhasil : {berhasil} data\n" +
                    $"✗ Gagal    : {gagal} data\n" +
                    $"⊘ Dilewati : {dilewati} data (duplikat)",
                    "Hasil Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi database:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormImportPelanggan_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tailorDBDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.tailorDBDataSet.Pelanggan);

        }
    }
}
