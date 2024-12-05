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

namespace Paperite
{
    public partial class Register : Form
    {
        private string conStr = "Data Source=LENOVO\\SQLEXPRESS; " + "Initial Catalog=Paperite; Integrated Security=True";
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua data harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Enkripsi password
            string encryptedPassword = EncryptPassword(password);

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO [user] (user_email, user_firstname, user_lastname, user_password) VALUES (@Email, @Firstname, @Lastname, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Firstname", firstname);
                        cmd.Parameters.AddWithValue("@Lastname", lastname);
                        cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registrasi berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            acc_created acc = new acc_created();
                            acc.Show();
                            this.Close(); // Tutup form register
                        }
                        else
                        {
                            MessageBox.Show("Registrasi gagal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fungsi untuk enkripsi password menggunakan SHA-256
        private string EncryptPassword(string plainPassword)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(plainPassword));
                return Convert.ToBase64String(bytes);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
