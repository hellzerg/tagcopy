namespace TagCopy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMp3 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTags = new System.Windows.Forms.Panel();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.btnBatchForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.picArt = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlac = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageBar = new TagCopy.MessageItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTags.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αρχείο MP3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtMp3
            // 
            this.txtMp3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMp3.ForeColor = System.Drawing.Color.White;
            this.txtMp3.Location = new System.Drawing.Point(12, 121);
            this.txtMp3.Name = "txtMp3";
            this.txtMp3.Size = new System.Drawing.Size(276, 32);
            this.txtMp3.TabIndex = 7;
            this.txtMp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(297, 136);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 36);
            this.btnCopy.TabIndex = 82;
            this.btnCopy.Tag = "themeable";
            this.btnCopy.Text = "Αντιγραφή";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTags);
            this.panel1.Controls.Add(this.divider);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtMp3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 445);
            this.panel1.TabIndex = 84;
            // 
            // panelTags
            // 
            this.panelTags.Controls.Add(this.txtComments);
            this.panelTags.Controls.Add(this.label7);
            this.panelTags.Controls.Add(this.txtGenre);
            this.panelTags.Controls.Add(this.label6);
            this.panelTags.Controls.Add(this.txtContrib);
            this.panelTags.Controls.Add(this.label5);
            this.panelTags.Controls.Add(this.txtArtist);
            this.panelTags.Controls.Add(this.label4);
            this.panelTags.Location = new System.Drawing.Point(3, 157);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(285, 346);
            this.panelTags.TabIndex = 10;
            this.panelTags.Visible = false;
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtComments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.ForeColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(0, 166);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(285, 71);
            this.txtComments.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(0, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Σχόλια";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.ForeColor = System.Drawing.Color.White;
            this.txtGenre.Location = new System.Drawing.Point(0, 119);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(285, 22);
            this.txtGenre.TabIndex = 14;
            this.txtGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(0, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Είδος";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContrib
            // 
            this.txtContrib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtContrib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrib.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContrib.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrib.ForeColor = System.Drawing.Color.White;
            this.txtContrib.Location = new System.Drawing.Point(0, 72);
            this.txtContrib.Name = "txtContrib";
            this.txtContrib.ReadOnly = true;
            this.txtContrib.Size = new System.Drawing.Size(285, 22);
            this.txtContrib.TabIndex = 12;
            this.txtContrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(0, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Συμμετέχοντες";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtist.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.ForeColor = System.Drawing.Color.White;
            this.txtArtist.Location = new System.Drawing.Point(0, 25);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(285, 22);
            this.txtArtist.TabIndex = 10;
            this.txtArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Καλλιτέχνης";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.RoyalBlue;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.divider.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.ForeColor = System.Drawing.Color.White;
            this.divider.Location = new System.Drawing.Point(0, 153);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(292, 1);
            this.divider.TabIndex = 8;
            this.divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatchForm
            // 
            this.btnBatchForm.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBatchForm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBatchForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatchForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatchForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchForm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchForm.ForeColor = System.Drawing.Color.White;
            this.btnBatchForm.Location = new System.Drawing.Point(297, 176);
            this.btnBatchForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatchForm.Name = "btnBatchForm";
            this.btnBatchForm.Size = new System.Drawing.Size(120, 54);
            this.btnBatchForm.TabIndex = 88;
            this.btnBatchForm.Tag = "themeable";
            this.btnBatchForm.Text = "Μαζική Διαγραφή";
            this.btnBatchForm.UseVisualStyleBackColor = false;
            this.btnBatchForm.Click += new System.EventHandler(this.btnBatchForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnManual);
            this.panel2.Controls.Add(this.picArt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtFlac);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(422, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 445);
            this.panel2.TabIndex = 85;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(51, 175);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Tag = "themeable";
            this.btnSearch.Text = "Εύρεση artwork";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManual.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnManual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnManual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(210, 174);
            this.btnManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(41, 36);
            this.btnManual.TabIndex = 86;
            this.btnManual.Tag = "themeable";
            this.btnManual.Text = "...";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Visible = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // picArt
            // 
            this.picArt.Location = new System.Drawing.Point(51, 219);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(200, 200);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 13;
            this.picArt.TabStop = false;
            this.picArt.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 1);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFlac
            // 
            this.txtFlac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlac.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlac.ForeColor = System.Drawing.Color.White;
            this.txtFlac.Location = new System.Drawing.Point(3, 121);
            this.txtFlac.Name = "txtFlac";
            this.txtFlac.Size = new System.Drawing.Size(285, 32);
            this.txtFlac.TabIndex = 11;
            this.txtFlac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Αρχείο FLAC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageBar
            // 
            this.messageBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.messageBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.messageBar.ForeColor = System.Drawing.Color.Silver;
            this.messageBar.Location = new System.Drawing.Point(0, 445);
            this.messageBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageBar.Name = "messageBar";
            this.messageBar.Size = new System.Drawing.Size(722, 39);
            this.messageBar.TabIndex = 83;
            this.messageBar.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(312, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(722, 484);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBatchForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messageBar);
            this.Controls.Add(this.btnCopy);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TagCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTags.ResumeLayout(false);
            this.panelTags.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtMp3;
        private System.Windows.Forms.Button btnCopy;
        private MessageItem messageBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtFlac;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTags;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrib;
        private System.Windows.Forms.PictureBox picArt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnBatchForm;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

