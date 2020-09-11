namespace TagCopy
{
    partial class MessageItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageItem));
            this.ErrorImage = new System.Windows.Forms.PictureBox();
            this.OkImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorImage
            // 
            this.ErrorImage.Image = ((System.Drawing.Image)(resources.GetObject("ErrorImage.Image")));
            this.ErrorImage.Location = new System.Drawing.Point(3, 3);
            this.ErrorImage.Name = "ErrorImage";
            this.ErrorImage.Size = new System.Drawing.Size(30, 31);
            this.ErrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ErrorImage.TabIndex = 85;
            this.ErrorImage.TabStop = false;
            // 
            // OkImage
            // 
            this.OkImage.Image = ((System.Drawing.Image)(resources.GetObject("OkImage.Image")));
            this.OkImage.Location = new System.Drawing.Point(3, 3);
            this.OkImage.Name = "OkImage";
            this.OkImage.Size = new System.Drawing.Size(30, 31);
            this.OkImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OkImage.TabIndex = 86;
            this.OkImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InfoImage);
            this.panel1.Controls.Add(this.ErrorImage);
            this.panel1.Controls.Add(this.OkImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 87);
            this.panel1.TabIndex = 87;
            // 
            // InfoImage
            // 
            this.InfoImage.Image = ((System.Drawing.Image)(resources.GetObject("InfoImage.Image")));
            this.InfoImage.Location = new System.Drawing.Point(3, 3);
            this.InfoImage.Name = "InfoImage";
            this.InfoImage.Size = new System.Drawing.Size(30, 31);
            this.InfoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoImage.TabIndex = 86;
            this.InfoImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HideButton);
            this.panel2.Controls.Add(this.Message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(48, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 87);
            this.panel2.TabIndex = 88;
            // 
            // HideButton
            // 
            this.HideButton.AutoSize = true;
            this.HideButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.HideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.HideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.HideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.HideButton.ForeColor = System.Drawing.Color.White;
            this.HideButton.Location = new System.Drawing.Point(198, 0);
            this.HideButton.Margin = new System.Windows.Forms.Padding(2);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(68, 87);
            this.HideButton.TabIndex = 83;
            this.HideButton.Tag = "themeable";
            this.HideButton.Text = "Εντάξει";
            this.HideButton.UseVisualStyleBackColor = false;
            this.HideButton.Visible = false;
            this.HideButton.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Message
            // 
            this.Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message.ForeColor = System.Drawing.Color.LightGray;
            this.Message.Location = new System.Drawing.Point(0, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(266, 87);
            this.Message.TabIndex = 0;
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageItem";
            this.Size = new System.Drawing.Size(314, 87);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OkImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.PictureBox ErrorImage;
        protected internal System.Windows.Forms.PictureBox OkImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Label Message;
        protected internal System.Windows.Forms.PictureBox InfoImage;
        protected internal System.Windows.Forms.Button HideButton;
    }
}
