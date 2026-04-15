using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZTailor
{
    public partial class FormPesanan: Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=LAPTOPAQA\\AQASAMA;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public FormPesanan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
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
                "SELECT p.id_pesanan, pl.nama, p.jenis_pakaian, p.tanggal_pesan, p.harga " +
                "FROM Pesanan p JOIN Pelanggan pl ON p.id_pelanggan = pl.id_pelanggan",
                conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void FormPesanan_Load(object sender, EventArgs e)
        {
            LoadPelanggan();
            TampilData();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Pesanan VALUES(@id, @jenis, @tgl, @harga)", conn);

            cmd.Parameters.AddWithValue("@id", cbPelanggan.SelectedValue);
            cmd.Parameters.AddWithValue("@jenis", txtJenis.Text);
            cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value);
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pesanan berhasil ditambahkan");

            TampilData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbPelanggan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtJenis.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtTanggal.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            txtHarga.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "UPDATE Pesanan SET id_pelanggan=@id, jenis_pakaian=@jenis, tanggal_pesan=@tgl, harga=@harga WHERE id_pesanan=@idpesanan",
                conn);

            cmd.Parameters.AddWithValue("@id", cbPelanggan.SelectedValue);
            cmd.Parameters.AddWithValue("@jenis", txtJenis.Text);
            cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value);
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text);

            cmd.Parameters.AddWithValue("@idpesanan",
                dataGridView1.CurrentRow.Cells[0].Value.ToString());

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pesanan berhasil diupdate");

            TampilData();
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Pesanan WHERE id_pesanan=@id", conn);

            cmd.Parameters.AddWithValue("@id",
                dataGridView1.CurrentRow.Cells[0].Value.ToString());

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Pesanan berhasil dihapus");

            TampilData();
        }
    }
}
