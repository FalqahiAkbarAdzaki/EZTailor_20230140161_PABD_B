using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EZTailor
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString =
            "Data Source=LAPTOPAQA\\AQASAMA;Initial Catalog=TailorDB;Integrated Security=True";

        public static string RoleAktif { get; private set; } = "";
        public static string NamaUser { get; private set; } = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT role, nama_lengkap FROM Users WHERE username=@u AND password=@p",
                        conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        RoleAktif = reader["role"].ToString();
                        NamaUser = reader["nama_lengkap"].ToString();
                        reader.Close();

                        MessageBox.Show($"Selamat datang, {NamaUser}!\nRole: {RoleAktif}",
                            "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Username atau Password salah!", "Login Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi database gagal:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hubungi Administrator untuk reset password.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
