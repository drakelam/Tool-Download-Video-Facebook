namespace download_video_fb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtVideoURL = new System.Windows.Forms.TextBox();
            this.combVideo = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.foldervideo = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDownload.Location = new System.Drawing.Point(149, 151);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtVideoURL
            // 
            this.txtVideoURL.BackColor = System.Drawing.Color.AliceBlue;
            this.txtVideoURL.Location = new System.Drawing.Point(11, 14);
            this.txtVideoURL.Name = "txtVideoURL";
            this.txtVideoURL.Size = new System.Drawing.Size(367, 20);
            this.txtVideoURL.TabIndex = 1;
            this.txtVideoURL.Text = "https://www.facebook.com/DrakeLam.Dev/videos/267922531196680";
            // 
            // combVideo
            // 
            this.combVideo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.combVideo.FormattingEnabled = true;
            this.combVideo.Items.AddRange(new object[] {
            "Chất lượng 480p",
            "Chất lượng 720p"});
            this.combVideo.Location = new System.Drawing.Point(126, 67);
            this.combVideo.Name = "combVideo";
            this.combVideo.Size = new System.Drawing.Size(121, 21);
            this.combVideo.TabIndex = 3;
            this.combVideo.Text = "Chất lượng 480p";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.LimeGreen;
            this.status.Location = new System.Drawing.Point(59, 106);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(69, 13);
            this.status.TabIndex = 5;
            this.status.Text = "Trạng Thái";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.ForeColor = System.Drawing.Color.Honeydew;
            this.progressBar1.Location = new System.Drawing.Point(62, 122);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // foldervideo
            // 
            this.foldervideo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.foldervideo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.foldervideo.FormattingEnabled = true;
            this.foldervideo.Items.AddRange(new object[] {
            "C:\\",
            "D:\\",
            "F:\\"});
            this.foldervideo.Location = new System.Drawing.Point(98, 40);
            this.foldervideo.Name = "foldervideo";
            this.foldervideo.Size = new System.Drawing.Size(193, 21);
            this.foldervideo.TabIndex = 7;
            this.foldervideo.Text = "C:\\video.mp4";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.SandyBrown;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(300, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by drakelam.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(390, 219);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.foldervideo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.combVideo);
            this.Controls.Add(this.txtVideoURL);
            this.Controls.Add(this.btnDownload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tool Download Video Facebook - DrakeLam.Com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtVideoURL;
        private System.Windows.Forms.ComboBox combVideo;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox foldervideo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

