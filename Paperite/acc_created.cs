﻿using System;
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
    public partial class acc_created : Form
    {
        public acc_created()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void acc_created_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
