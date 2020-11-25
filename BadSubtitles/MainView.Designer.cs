namespace BadSubtitles
{
    partial class MainView
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
            this.uploadBTN = new System.Windows.Forms.Button();
            this.textBoxSubs = new System.Windows.Forms.RichTextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadBTN
            // 
            this.uploadBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uploadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBTN.ForeColor = System.Drawing.Color.Black;
            this.uploadBTN.Location = new System.Drawing.Point(13, 13);
            this.uploadBTN.Name = "uploadBTN";
            this.uploadBTN.Size = new System.Drawing.Size(180, 43);
            this.uploadBTN.TabIndex = 0;
            this.uploadBTN.Text = "UPLOAD";
            this.uploadBTN.UseVisualStyleBackColor = true;
            this.uploadBTN.Click += new System.EventHandler(this.uploadBTN_Click);
            // 
            // textBoxSubs
            // 
            this.textBoxSubs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxSubs.Location = new System.Drawing.Point(0, 66);
            this.textBoxSubs.Name = "textBoxSubs";
            this.textBoxSubs.Size = new System.Drawing.Size(583, 362);
            this.textBoxSubs.TabIndex = 2;
            this.textBoxSubs.Text = "";
            // 
            // convertBtn
            // 
            this.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertBtn.ForeColor = System.Drawing.Color.Black;
            this.convertBtn.Location = new System.Drawing.Point(199, 13);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(180, 43);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // download
            // 
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download.ForeColor = System.Drawing.Color.Black;
            this.download.Location = new System.Drawing.Point(385, 13);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(180, 43);
            this.download.TabIndex = 4;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(583, 428);
            this.Controls.Add(this.download);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.textBoxSubs);
            this.Controls.Add(this.uploadBTN);
            this.Name = "MainView";
            this.Text = "Bad Subs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadBTN;
        private System.Windows.Forms.RichTextBox textBoxSubs;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Button download;
    }
}

