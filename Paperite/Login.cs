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
        private string conStr = "Data Source=LENOVO\\SQLEXPRESS; " + "Initial Catalog=Paperite; Integrated Security=True";
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
                    string query = "SELECT COUNT(1) FROM [user] WHERE user_email = @email AND user_password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", encryptedPassword);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
