namespace TagCopy
{
    partial class BatchOpsForm
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
            this.trackList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatchDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteComments = new System.Windows.Forms.CheckBox();
            this.deleteAlbum = new System.Windows.Forms.CheckBox();
            this.deleteYear = new System.Windows.Forms.CheckBox();
            this.deleteSubtitle = new System.Windows.Forms.CheckBox();
            this.deleteTrackNumber = new System.Windows.Forms.CheckBox();
            this.matchArtists = new System.Windows.Forms.CheckBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackList.ForeColor = System.Drawing.Color.Silver;
            this.trackList.FormattingEnabled = true;
            this.trackList.ItemHeight = 21;
            this.trackList.Location = new System.Drawing.Point(17, 49);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(295, 317);
            this.trackList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Λίστα κομματιών";
            // 
            // btnBatchDelete
            // 
            this.btnBatchDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBatchDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBatchDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatchDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatchDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchDelete.ForeColor = System.Drawing.Color.White;
            this.btnBatchDelete.Location = new System.Drawing.Point(424, 445);
            this.btnBatchDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatchDelete.Name = "btnBatchDelete";
            this.btnBatchDelete.Size = new System.Drawing.Size(196, 36);
            this.btnBatchDelete.TabIndex = 83;
            this.btnBatchDelete.Tag = "themeable";
            this.btnBatchDelete.Text = "Μαζική Διαγραφή";
            this.btnBatchDelete.UseVisualStyleBackColor = false;
            this.btnBatchDelete.Click += new System.EventHandler(this.btnBatchDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Επιλογές";
            // 
            // deleteComments
            // 
            this.deleteComments.AutoSize = true;
            this.deleteComments.Location = new System.Drawing.Point(346, 49);
            this.deleteComments.Name = "deleteComments";
            this.deleteComments.Size = new System.Drawing.Size(172, 25);
            this.deleteComments.TabIndex = 85;
            this.deleteComments.Text = "Διαγραφή Σχολίων";
            this.deleteComments.UseVisualStyleBackColor = true;
            // 
            // deleteAlbum
            // 
            this.deleteAlbum.AutoSize = true;
            this.deleteAlbum.Location = new System.Drawing.Point(346, 80);
            this.deleteAlbum.Name = "deleteAlbum";
            this.deleteAlbum.Size = new System.Drawing.Size(178, 25);
            this.deleteAlbum.TabIndex = 86;
            this.deleteAlbum.Text = "Διαγραφή Άλμπουμ";
            this.deleteAlbum.UseVisualStyleBackColor = true;
            // 
            // deleteYear
            // 
            this.deleteYear.AutoSize = true;
            this.deleteYear.Location = new System.Drawing.Point(346, 111);
            this.deleteYear.Name = "deleteYear";
            this.deleteYear.Size = new System.Drawing.Size(154, 25);
            this.deleteYear.TabIndex = 87;
            this.deleteYear.Text = "Διαγραφή Έτους";
            this.deleteYear.UseVisualStyleBackColor = true;
            // 
            // deleteSubtitle
            // 
            this.deleteSubtitle.AutoSize = true;
            this.deleteSubtitle.Location = new System.Drawing.Point(346, 142);
            this.deleteSubtitle.Name = "deleteSubtitle";
            this.deleteSubtitle.Size = new System.Drawing.Size(187, 25);
            this.deleteSubtitle.TabIndex = 88;
            this.deleteSubtitle.Text = "Διαγραφή Υποτίτλου";
            this.deleteSubtitle.UseVisualStyleBackColor = true;
            // 
            // deleteTrackNumber
            // 
            this.deleteTrackNumber.AutoSize = true;
            this.deleteTrackNumber.Location = new System.Drawing.Point(346, 173);
            this.deleteTrackNumber.Name = "deleteTrackNumber";
            this.deleteTrackNumber.Size = new System.Drawing.Size(260, 25);
            this.deleteTrackNumber.TabIndex = 89;
            this.deleteTrackNumber.Text = "Διαγραφή Αριθμού Κομματιού";
            this.deleteTrackNumber.UseVisualStyleBackColor = true;
            // 
            // matchArtists
            // 
            this.matchArtists.Location = new System.Drawing.Point(346, 204);
            this.matchArtists.Name = "matchArtists";
            this.matchArtists.Size = new System.Drawing.Size(260, 52);
            this.matchArtists.TabIndex = 90;
            this.matchArtists.Text = "Αντιστοίχιση Καλλιτεχνών με Συμμετέχοντες";
            this.matchArtists.UseVisualStyleBackColor = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(17, 372);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(295, 17);
            this.progress.TabIndex = 91;
            // 
            // BatchOpsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(631, 492);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.matchArtists);
            this.Controls.Add(this.deleteTrackNumber);
            this.Controls.Add(this.deleteSubtitle);
            this.Controls.Add(this.deleteYear);
            this.Controls.Add(this.deleteAlbum);
            this.Controls.Add(this.deleteComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatchDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackList);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchOpsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Μαζική Διαγραφή Πληροφοριών MP3";
            this.Load += new System.EventHandler(this.CommentDeleter_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CommentDeleter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CommentDeleter_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatchDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox deleteComments;
        private System.Windows.Forms.CheckBox deleteAlbum;
        private System.Windows.Forms.CheckBox deleteYear;
        private System.Windows.Forms.CheckBox deleteSubtitle;
        private System.Windows.Forms.CheckBox deleteTrackNumber;
        private System.Windows.Forms.CheckBox matchArtists;
        private System.Windows.Forms.ProgressBar progress;
    }
}