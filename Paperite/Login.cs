using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace Paperite
{
    public partial class Login : Form
    {
        private string conStr = "Data Source=iydheko11\\SQLEXPRESS; " + "Initial Catalog=Paperite; Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string encryptedPassword = EncryptPassword(password);

            // Cek login
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();

                    // Query untuk mengambil user_id
                    string query = "SELECT user_id FROM [users] WHERE user_email = @Email AND user_password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                        // Eksekusi query dan ambil user_id
                        object result = cmd.ExecuteScalar();

                        if (result != null) // Jika user ditemukan
                        {
                            string userId = result.ToString(); // Konversi user_id ke string
                            MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Simpan user_id ke Settings
                            Properties.Settings.Default.UserId = userId;
                            Properties.Settings.Default.IsLoggedIn = true;
                            Properties.Settings.Default.Save();

                            // Buka form utama
                            Paperite home = new Paperite();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        // Fungsi untuk enkripsi password
        private string EncryptPassword(string plainPassword)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(plainPassword));
                return Convert.ToBase64String(bytes);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
