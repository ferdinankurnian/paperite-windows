namespace Paperite
{
    partial class Paperite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paperite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainerNote = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.noteTitleBox = new System.Windows.Forms.TextBox();
            this.noteContentBox = new System.Windows.Forms.RichTextBox();
            this.btnDeleteNote = new System.Windows.Forms.PictureBox();
            this.btnInfoNote = new System.Windows.Forms.PictureBox();
            this.btnPinNote = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddNote = new System.Windows.Forms.PictureBox();
            this.btnProfileMenu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPinNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfileMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelContainerNote);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 523);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelContainerNote
            // 
            this.panelContainerNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelContainerNote.AutoScroll = true;
            this.panelContainerNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelContainerNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerNote.Location = new System.Drawing.Point(2, 78);
            this.panelContainerNote.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainerNote.Name = "panelContainerNote";
            this.panelContainerNote.Size = new System.Drawing.Size(319, 440);
            this.panelContainerNote.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Location = new System.Drawing.Point(1, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 32);
            this.panel4.TabIndex = 5;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(35, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(278, 18);
            this.searchBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddNote);
            this.panel2.Controls.Add(this.btnProfileMenu);
            this.panel2.Controls.Add(this.formTitle);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 47);
            this.panel2.TabIndex = 1;
            // 
            // formTitle
            // 
            this.formTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.formTitle.Location = new System.Drawing.Point(124, 15);
            this.formTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(72, 19);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Paperite";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDeleteNote);
            this.panel3.Controls.Add(this.btnInfoNote);
            this.panel3.Controls.Add(this.btnPinNote);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 50);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.noteTitleBox);
            this.panel6.Controls.Add(this.noteContentBox);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(319, -7);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(563, 525);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // noteTitleBox
            // 
            this.noteTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTitleBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitleBox.Location = new System.Drawing.Point(24, 66);
            this.noteTitleBox.Name = "noteTitleBox";
            this.noteTitleBox.Size = new System.Drawing.Size(519, 22);
            this.noteTitleBox.TabIndex = 11;
            this.noteTitleBox.Text = "Judul Catatan";
            this.noteTitleBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // noteContentBox
            // 
            this.noteContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteContentBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContentBox.Location = new System.Drawing.Point(21, 98);
            this.noteContentBox.Name = "noteContentBox";
            this.noteContentBox.Size = new System.Drawing.Size(522, 423);
            this.noteContentBox.TabIndex = 10;
            this.noteContentBox.Text = resources.GetString("noteContentBox.Text");
            this.noteContentBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNote.Image = global::Paperite.Properties.Resources.delete;
            this.btnDeleteNote.Location = new System.Drawing.Point(533, 17);
            this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteNote.TabIndex = 5;
            this.btnDeleteNote.TabStop = false;
            // 
            // btnInfoNote
            // 
            this.btnInfoNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoNote.Image = global::Paperite.Properties.Resources.info;
            this.btnInfoNote.Location = new System.Drawing.Point(498, 17);
            this.btnInfoNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoNote.Name = "btnInfoNote";
            this.btnInfoNote.Size = new System.Drawing.Size(20, 20);
            this.btnInfoNote.TabIndex = 4;
            this.btnInfoNote.TabStop = false;
            // 
            // btnPinNote
            // 
            this.btnPinNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPinNote.Image = global::Paperite.Properties.Resources.keep;
            this.btnPinNote.Location = new System.Drawing.Point(10, 17);
            this.btnPinNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinNote.Name = "btnPinNote";
            this.btnPinNote.Size = new System.Drawing.Size(20, 20);
            this.btnPinNote.TabIndex = 3;
            this.btnPinNote.TabStop = false;
            this.btnPinNote.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Paperite.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(6, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNote.Image = global::Paperite.Properties.Resources.add_notes;
            this.btnAddNote.Location = new System.Drawing.Point(288, 13);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(20, 20);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.TabStop = false;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnProfileMenu
            // 
            this.btnProfileMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfileMenu.Image = global::Paperite.Properties.Resources.userpfp;
            this.btnProfileMenu.Location = new System.Drawing.Point(9, 12);
            this.btnProfileMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfileMenu.Name = "btnProfileMenu";
            this.btnProfileMenu.Size = new System.Drawing.Size(25, 25);
            this.btnProfileMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProfileMenu.TabIndex = 1;
            this.btnProfileMenu.TabStop = false;
            this.btnProfileMenu.Click += new System.EventHandler(this.btnProfileMenu_Click);
            // 
            // Paperite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 514);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Paperite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paperite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Paperite_FormClosed);
            this.Load += new System.EventHandler(this.Paperite_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPinNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfileMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.PictureBox btnProfileMenu;
        private System.Windows.Forms.PictureBox btnAddNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnDeleteNote;
        private System.Windows.Forms.PictureBox btnInfoNote;
        private System.Windows.Forms.PictureBox btnPinNote;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox noteContentBox;
        private System.Windows.Forms.TextBox noteTitleBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel panelContainerNote;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

