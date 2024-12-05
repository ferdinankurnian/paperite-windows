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
    public partial class Paperite : Form
    {
        private string connectionString = "Data Source=iydheko11\\SQLEXPRESS; " + "Initial Catalog=Paperite; Integrated Security=True";
        private int panelHeight = 60; // Tinggi setiap panel
        private int panelSpacing = 1;
        private int currentPanelCount = 0; // Jumlah panel saat ini

        private int currentNoteId = -1;

        public Paperite()
        {
            InitializeComponent();

            TidyupPanel();
            btnAddNote.Click += AddPanel;

            LoadNotes();
        }

        // Fungsi untuk memuat data dari database dan menambahkannya ke dalam panel
        public void LoadNotes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Membuka koneksi ke database

                    // SQL query untuk mengambil data dari tabel notes
                    string query = "SELECT note_id, note_title, note_content FROM notes";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Menjalankan query dan mengambil data
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Jika ada data yang ditemukan
                    while (reader.Read())
                    {
                        int noteId = reader.GetInt32(0); // Ambil note_id
                        string noteTitle = reader.GetString(1); // Ambil note_title
                        string noteContent = reader.GetString(2); // Ambil note_content

                        Panel newPanel = APanel(noteTitle, noteContent);

                        // Menambahkan panel ke dalam FlowLayoutPanel
                        panelContainerNote.Controls.Add(newPanel);

                        TidyupPanel();
                    }

                    reader.Close(); // Menutup reader setelah selesai
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}"); // Menampilkan pesan jika ada error
                }
            }
        }

        private Panel APanel(string titleNote, string contentNote)
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

            PictureBox pinIcon = new PictureBox
            {
                Image = Properties.Resources.keep, // Pastikan Anda memiliki file ikon di resource
                Size = new Size(16, 16),
                Location = new Point(5, 5), // Posisi pin di kiri atas
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Judul Label
            Label titleLabel = new Label
            {
                Text = $"{titleNote}",
                Font = new Font("Arial", 9, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(22, 5, 10, 5),
            };

            // Isi Konten Label
            Label contentLabel = new Label
            {
                Text = $"{contentNote}",
                Font = new Font("Arial", 8),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(22, 0, 10, 5),
                AutoEllipsis = true,
            };

            newPanel.Click += (s, args) =>
            {
                // Tampilkan data ke TextBox dan RichTextBox
                noteTitleBox.Text = titleLabel.Text; // Menampilkan judul di TextBox
                noteContentBox.Text = contentLabel.Text; // Menampilkan konten di RichTextBox
                panelColorEnter(newPanel);
            };

            titleLabel.Click += (s, args) =>
            {
                // Tampilkan data ke TextBox dan RichTextBox
                noteTitleBox.Text = titleLabel.Text; // Menampilkan judul di TextBox
                noteContentBox.Text = contentLabel.Text; // Menampilkan konten di RichTextBox
            };

            contentLabel.Click += (s, args) =>
            {
                // Tampilkan data ke TextBox dan RichTextBox
                noteTitleBox.Text = titleLabel.Text; // Menampilkan judul di TextBox
                noteContentBox.Text = contentLabel.Text; // Menampilkan konten di RichTextBox
            };


            pinIcon.Click += (s, args) =>
            {
                // Tampilkan data ke TextBox dan RichTextBox
                noteTitleBox.Text = titleLabel.Text; // Menampilkan judul di TextBox
                noteContentBox.Text = contentLabel.Text; // Menampilkan konten di RichTextBox
            };

            // Hover effect untuk panel
            newPanel.MouseEnter += (s, args) =>
            {
                panelColorEnter(newPanel);
            };
            newPanel.MouseLeave += (s, args) =>
            {
                panelColorLeave(newPanel);
            };

            // Hover effect untuk label dan pinIcon jika diinginkan
            titleLabel.MouseEnter += (s, args) =>
            {
                panelColorEnter(newPanel);
            };

            titleLabel.MouseLeave += (s, args) =>
            {
                panelColorLeave(newPanel);
            };

            contentLabel.MouseEnter += (s, args) =>
            {
                panelColorEnter(newPanel);
            };

            contentLabel.MouseLeave += (s, args) =>
            {
                panelColorLeave(newPanel);
            };

            pinIcon.MouseEnter += (s, args) =>
            {
                panelColorEnter(newPanel);
            };

            pinIcon.MouseLeave += (s, args) =>
            {
                panelColorLeave(newPanel);
            };

            // Menambahkan label ke dalam panel
            newPanel.Controls.Add(pinIcon);
            newPanel.Controls.Add(contentLabel);
            newPanel.Controls.Add(titleLabel);

            return newPanel;
        }


        private void AddPanel(object sender, EventArgs e)
        {
            string newTitle = $"Judul Catatan #{currentPanelCount + 1}";
            string newContent = "";

            Panel newPanel = APanel(newTitle, newContent);

            // Tambahkan ke FlowLayoutPanel
            panelContainerNote.Controls.Add(newPanel);

            // Pastikan panel berada di depan kontrol lain
            newPanel.BringToFront();

            AddNoteToDatabase(newTitle, newContent);

            // Increment counter
            currentPanelCount++;

            TidyupPanel();
        }

        private void panelColorEnter(Panel panel)
        {
            panel.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void panelColorLeave(Panel panel)
        {
            panel.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void AddNoteToDatabase(string noteTitle, string noteContent)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Membuka koneksi ke database

                    // SQL query untuk memasukkan data ke tabel notes
                    string query = "INSERT INTO notes (note_user_id, note_title, note_content, note_ispinned, note_date_created, note_date_modified) " +
                                   "VALUES (@noteUserId, @noteTitle, @noteContent, @noteIspinned, @noteDateCreated, @noteDateModified)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@noteUserId", Properties.Settings.Default.UserId); // Menggunakan user_id yang sudah tersimpan
                    cmd.Parameters.AddWithValue("@noteTitle", noteTitle);
                    cmd.Parameters.AddWithValue("@noteContent", noteContent);
                    cmd.Parameters.AddWithValue("@noteIspinned", "false"); // Misalnya catatan belum dipin
                    cmd.Parameters.AddWithValue("@noteDateCreated", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@noteDateModified", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    // Eksekusi query untuk memasukkan data
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Catatan berhasil disimpan ke database!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnProfileMenu_Click(object sender, EventArgs e)
        {
            Profile profmenu = new Profile();
            profmenu.Show();
        }
    }
}
