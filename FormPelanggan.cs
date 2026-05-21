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

        BindingSource bs = new BindingSource();
        int selectedId = 0;
        public FormPelanggan()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = bs;
            TampilData();
        }
        void TampilData()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                    "SELECT * FROM vw_Pelanggan",
                    conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            bs.DataSource = dt;

            dataGridView1.DataSource = bs;
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_InsertPelanggan", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil ditambahkan");

                TampilData();

                txtId.Clear();
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

            SqlCommand cmd = new SqlCommand("sp_DeletePelanggan", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", selectedId);

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

                txtId.Text =
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

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

                SqlCommand cmd = new SqlCommand("sp_UpdatePelanggan", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Data berhasil diupdate");

                TampilData();

                txtId.Clear();
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

        private void lblNoHp_Click(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "sp_SearchPelanggan", conn);

            da.SelectCommand.CommandType =
                CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue(
                "@keyword", txtCari.Text);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCariVulnerableClick( object sender,EventArgs e)
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Pelanggan WHERE nama='"
                + txtCari.Text + "'",
                conn);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnReset_Click(
     object sender,
     EventArgs e)
        {
            txtCari.Clear();


            TampilData();
        }
    }
}
