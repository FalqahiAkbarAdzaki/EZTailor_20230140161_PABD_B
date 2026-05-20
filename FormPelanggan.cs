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

    public partial class FormPelanggan: Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=LAPTOPAQA\\AQASAMA;Initial Catalog=TailorDB;Integrated Security=True";


        int selectedId = 0;
        public FormPelanggan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TampilData();
        }
        void TampilData()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM vw_Pelanggan", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Pelanggan(nama,no_hp,alamat) VALUES(@nama,@hp,@alamat)",
                    conn);

                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil ditambahkan");

                TampilData();

                txtNama.Clear();
                txtNoHP.Clear();
                txtAlamat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                conn.Close();
            }
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Pelanggan WHERE id_pelanggan=@id", conn);

            cmd.Parameters.AddWithValue("@id",
                dataGridView1.CurrentRow.Cells[0].Value.ToString());

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data berhasil dihapus");

            TampilData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                txtNama.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtNoHP.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtAlamat.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Pelanggan SET nama=@nama, no_hp=@hp, alamat=@alamat WHERE id_pelanggan=@id",
                    conn);

                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);

                cmd.Parameters.AddWithValue("@id", selectedId);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil diupdate");

                TampilData();

                txtNama.Clear();
                txtNoHP.Clear();
                txtAlamat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}
