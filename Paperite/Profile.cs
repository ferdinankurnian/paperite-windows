using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paperite
{
    public partial class Profile : Form
    {
        private string conStr = "Data Source=iydheko11\\SQLEXPRESS; " + "Initial Catalog=Paperite; Integrated Security=True";
        public Profile()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void closeThis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Log Out Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logOut();
            }
            else
            {
                return;
            }
            
        }
        private void lblLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                                                  "Log Out Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                logOut();
            }
            else
            {
                return;
            }
        }

        private void logOut()
        {
            Properties.Settings.Default.UserId = string.Empty;
            Properties.Settings.Default.IsLoggedIn = false;
            Properties.Settings.Default.Save();

            Application.Restart();
        }

    }
}
