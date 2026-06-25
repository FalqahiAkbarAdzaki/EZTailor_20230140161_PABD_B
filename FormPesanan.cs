using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
// Tambahkan referensi NuGet: EPPlus (ClosedXML atau ExcelDataReader)
// Install via NuGet: Install-Package ClosedXML
using ClosedXML.Excel;

namespace EZTailor
{
    /// <summary>
    /// FormPesanan - Revisi UCP3
    /// Perubahan:
    /// 1. jenis_pakaian diubah dari TextBox menjadi CheckedListBox (checklist)
    /// 2. Tambah fitur Import dari Excel
    /// 3. Tambah fitur Export ke Excel (Report)
    /// 4. Menggunakan Stored Procedure untuk semua operasi DB
    /// </summary>
    public partial class FormPesanan : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOPAQA\\AQASAMA;Initial Catalog=TailorDB;Integrated Security=True";

        // Daftar jenis pakaian untuk checklist
        private readonly string[] daftarJenisPakaian = {
            "Kemeja", "Celana", "Jas", "Gaun",
            "Batik", "Seragam", "Kebaya", "Rok"
        };

        public FormPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void FormPesanan_Load(object sender, EventArgs e)
        {
            // Isi checklist jenis pakaian
            foreach (string jenis in daftarJenisPakaian)
                clbJenisPakaian.Items.Add(jenis);

            LoadPelanggan();
            TampilData();

            // Batasi akses jika bukan admin
            if (FormLogin.RoleAktif != "admin")
            {
                btnImportExcel.Enabled = false;
                btnHapus.Enabled = false;
            }
        }

        void LoadPelanggan()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT id_pelanggan, nama FROM Pelanggan", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbPelanggan.DataSource = dt;
            cbPelanggan.DisplayMember = "nama";
            cbPelanggan.ValueMember = "id_pelanggan";
        }

        void TampilData()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM vw_LaporanPesanan ORDER BY tanggal_pesan DESC", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // ----------------------------------------
        // Ambil jenis pakaian dari checklist
        // ----------------------------------------
        private string GetJenisPakaianTerpilih()
        {
            var terpilih = new System.Collections.Generic.List<string>();
            foreach (var item in clbJenisPakaian.CheckedItems)
                terpilih.Add(item.ToString());
            return string.Join(", ", terpilih);
        }

        // ----------------------------------------
        // Set checklist berdasarkan string dari DB
        // ----------------------------------------
        private void SetChecklist(string jenisPakaian)
        {
            // Reset semua
            for (int i = 0; i < clbJenisPakaian.Items.Count; i++)
                clbJenisPakaian.SetItemChecked(i, false);

            if (string.IsNullOrEmpty(jenisPakaian)) return;

            string[] items = jenisPakaian.Split(',');
            foreach (string item in items)
            {
                string trimmed = item.Trim();
                int idx = clbJenisPakaian.Items.IndexOf(trimmed);
                if (idx >= 0)
                    clbJenisPakaian.SetItemChecked(idx, true);
            }
        }

        // ----------------------------------------
        // TAMBAH PESANAN
        // ----------------------------------------
        private void btnTambah_Click(object sender, EventArgs e)
        {
            string jenisPakaian = GetJenisPakaianTerpilih();

            if (string.IsNullOrEmpty(jenisPakaian))
            {
                MessageBox.Show("Pilih minimal satu jenis pakaian!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga) || harga < 10000)
            {
                MessageBox.Show("Harga minimal Rp 10.000!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_InsertPesanan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pelanggan", cbPelanggan.SelectedValue);
                cmd.Parameters.AddWithValue("@jenis_pakaian", jenisPakaian);
                cmd.Parameters.AddWithValue("@tanggal_pesan", dtTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pesanan berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilData();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------
        // UPDATE PESANAN
        // ----------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string jenisPakaian = GetJenisPakaianTerpilih();
            if (string.IsNullOrEmpty(jenisPakaian))
            {
                MessageBox.Show("Pilih minimal satu jenis pakaian!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHarga.Text, out decimal harga) || harga < 10000)
            {
                MessageBox.Show("Harga minimal Rp 10.000!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdatePesanan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pesanan", dataGridView1.CurrentRow.Cells["id_pesanan"].Value);
                cmd.Parameters.AddWithValue("@id_pelanggan", cbPelanggan.SelectedValue);
                cmd.Parameters.AddWithValue("@jenis_pakaian", jenisPakaian);
                cmd.Parameters.AddWithValue("@tanggal_pesan", dtTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pesanan berhasil diupdate!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
                TampilData();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------
        // HAPUS PESANAN
        // ----------------------------------------
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Yakin ingin menghapus pesanan ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DeletePesanan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pesanan",
                    dataGridView1.CurrentRow.Cells["id_pesanan"].Value);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Pesanan berhasil dihapus!", "Sukses");
                BersihkanForm();
                TampilData();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------
        // KLIK BARIS DATAGRID
        // ----------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Isi form dari data terpilih
            string namaPelanggan = row.Cells["nama_pelanggan"].Value?.ToString();
            for (int i = 0; i < cbPelanggan.Items.Count; i++)
            {
                DataRowView drv = (DataRowView)cbPelanggan.Items[i];
                if (drv["nama"].ToString() == namaPelanggan)
                {
                    cbPelanggan.SelectedIndex = i;
                    break;
                }
            }

            SetChecklist(row.Cells["jenis_pakaian"].Value?.ToString());

            if (DateTime.TryParse(row.Cells["tanggal_pesan"].Value?.ToString(), out DateTime tgl))
                dtTanggal.Value = tgl;

            txtHarga.Text = row.Cells["harga"].Value?.ToString();
        }

        // ----------------------------------------
        // IMPORT DARI EXCEL
        // ----------------------------------------
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Pilih File Excel Pesanan",
                Filter = "Excel Files (*.xlsx)|*.xlsx"
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            int berhasil = 0, gagal = 0;

            try
            {
                using (var workbook = new XLWorkbook(ofd.FileName))
                {
                    var ws = workbook.Worksheet(1);
                    int lastRow = ws.LastRowUsed().RowNumber();

                    // Baris 1 = header, mulai dari baris 2
                    for (int row = 2; row <= lastRow; row++)
                    {
                        try
                        {
                            string namaPelanggan = ws.Cell(row, 1).GetString().Trim();
                            string jenisPakaian = ws.Cell(row, 2).GetString().Trim();
                            string tanggalStr = ws.Cell(row, 3).GetString().Trim();
                            string hargaStr = ws.Cell(row, 4).GetString().Trim();

                            if (string.IsNullOrEmpty(namaPelanggan)) continue;

                            // Cari id_pelanggan berdasarkan nama
                            int idPelanggan = CariIdPelanggan(namaPelanggan);
                            if (idPelanggan <= 0)
                            {
                                gagal++;
                                continue;
                            }

                            if (!DateTime.TryParse(tanggalStr, out DateTime tanggal))
                                tanggal = DateTime.Today;

                            if (!decimal.TryParse(hargaStr, out decimal harga) || harga < 10000)
                            {
                                gagal++;
                                continue;
                            }

                            conn.Open();
                            SqlCommand cmd = new SqlCommand("sp_InsertPesanan", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_pelanggan", idPelanggan);
                            cmd.Parameters.AddWithValue("@jenis_pakaian", jenisPakaian);
                            cmd.Parameters.AddWithValue("@tanggal_pesan", tanggal.Date);
                            cmd.Parameters.AddWithValue("@harga", harga);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            berhasil++;
                        }
                        catch
                        {
                            if (conn.State == ConnectionState.Open) conn.Close();
                            gagal++;
                        }
                    }
                }

                MessageBox.Show(
                    $"Import selesai!\nBerhasil: {berhasil} data\nGagal: {gagal} data",
                    "Hasil Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca file Excel:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CariIdPelanggan(string nama)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 id_pelanggan FROM Pelanggan WHERE nama LIKE @nama", conn);
                cmd.Parameters.AddWithValue("@nama", "%" + nama + "%");
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                return 0;
            }
        }

        // ----------------------------------------
        // BUKA FORM REPORT
        // ----------------------------------------
        private void btnReport_Click(object sender, EventArgs e)
        {
            FormReport rpt = new FormReport();
            rpt.ShowDialog();
        }

        // ----------------------------------------
        // BERSIHKAN FORM
        // ----------------------------------------
        private void BersihkanForm()
        {
            for (int i = 0; i < clbJenisPakaian.Items.Count; i++)
                clbJenisPakaian.SetItemChecked(i, false);

            txtHarga.Clear();
            dtTanggal.Value = DateTime.Today;
        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void FormPesanan_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tailorDBDataSet1.Pesanan' table. You can move, or remove it, as needed.
            this.pesananTableAdapter.Fill(this.tailorDBDataSet1.Pesanan);

        }
    }
}