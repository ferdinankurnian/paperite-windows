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
    public partial class Paperite : Form
    {
        private int panelHeight = 75; // Tinggi setiap panel
        private int panelSpacing = 1;
        private int currentPanelCount = 0; // Jumlah panel saat ini

        public Paperite()
        {
            InitializeComponent();

            TidyupPanel();

            btnAddNote.Click += AddPanel;

            string current_title;
            string current_content;

        }

        private void AddPanel(object sender, EventArgs e)
        {
            int panelWidth = panelContainerNote.ClientSize.Width;

            // Jika scrollbar vertikal terlihat, kurangi lebar sedikit untuk memberi ruang untuk scrollbar
            if (!panelContainerNote.VerticalScroll.Visible)
            {
                panelWidth -= 17;
            }

            // Buat panel baru
            Panel newPanel = new Panel
            {
                Size = new Size(panelWidth, panelHeight), // Sesuaikan lebar dengan FlowLayoutPanel
                BackColor = Color.FromArgb(249, 249, 249),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            // Judul Label
            Label titleLabel = new Label
            {
                Text = $"Judul Catatan #{currentPanelCount + 1}",
                Font = new Font("Arial", 9, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 5, 10, 5), // Padding untuk memberi ruang di sekitar teks
            };

            // Isi Konten Label
            Label contentLabel = new Label
            {
                Text = "Deskripsi catatan disini. Lorem ipsum is simply dummy text of the printing and typesetting industry.",
                Font = new Font("Arial", 8),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(10, 0, 10, 5),
                AutoEllipsis = true,  // Mengaktifkan Ellipsis jika teks terlalu panjang
            };

            // Event klik untuk panel
            newPanel.Click += (s, args) =>
            {
                MessageBox.Show($"You clicked panel #{currentPanelCount + 1}");
            };

            // Hover effect untuk panel
            newPanel.MouseEnter += (s, args) =>
            {
                newPanel.BackColor = Color.FromArgb(230, 230, 230); // Mengubah warna saat hover
            };
            newPanel.MouseLeave += (s, args) =>
            {
                newPanel.BackColor = Color.FromArgb(249, 249, 249); // Mengembalikan warna saat hover hilang
            };

            // Menambahkan label ke dalam panel
            newPanel.Controls.Add(contentLabel);
            newPanel.Controls.Add(titleLabel);

            // Tambahkan ke FlowLayoutPanel
            panelContainerNote.Controls.Add(newPanel);

            // Increment counter
            currentPanelCount++;

            TidyupPanel();
        }

        public void TidyupPanel()
        {
            panelContainerNote.Margin = new Padding(0); // Mengatur margin di sekitar FlowLayoutPanel
            panelContainerNote.Padding = new Padding(0); // Mengatur padding di dalam FlowLayoutPanel

            // Mengatur jarak antar panel dalam FlowLayoutPanel menjadi 0
            foreach (Control control in panelContainerNote.Controls)
            {
                control.Margin = new Padding(0); // Mengatur margin setiap panel menjadi 0
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Paperite_Load(object sender, EventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Paperite_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
