/*
 * Tác giả: Drake Lam
 * Blog: Drake Lam Blog
 * Website: https://drakelam.com/
 * Facebook: https://www.facebook.com/DrakeLam.Dev/
 * Chào mừng các bạn! Cảm ơn các bạn đã theo dõi mình. Đây là Source CODE 
 * phần mềm download video Facebook.
 * Hướng dẫn xem tại địa chỉ: https://drakelam.com/source-code-phan-mem-download-video-facebook/
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace download_video_fb
{
    public partial class Form1 : Form
    {
        private HtmlWeb facebook = new HtmlWeb();
        enum ViddeoFB { HD, FullHD };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument down;
            string keystart = "";
            string keyend = "";

            try
            {
                down = facebook.Load(txtVideoURL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            switch ((ViddeoFB)combVideo.SelectedIndex)
            {
                case ViddeoFB.HD:
                    keystart = ",sd_src:\"";
                    keyend = "\",hd_tag:\"";
                    break;

                case ViddeoFB.FullHD:
                    keystart = ",hd_src:\"";
                    keyend = "\",sd_src:\"";
                    break;
            }
            
            
            var start = down.ParsedText.IndexOf(keystart);
            var end = down.ParsedText.IndexOf(keyend);
            string vidDownloadLink = down.ParsedText.Substring(start + keystart.Length, (end - keyend.Length + 1) - start);

            if (vidDownloadLink.Length > 0)
            {
                WebClient myWebClient = new WebClient();
                Uri uri = new Uri(vidDownloadLink);

                myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                // Specify a progress notification handler.
                myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

                myWebClient.DownloadFileAsync(uri, foldervideo.Text);

                /*Thread readFileThread = new Thread(() => DownloadVideo(vidDownloadLink));
                readFileThread.Start();*/
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            status.Text = "Quá trình tải " + e.BytesReceived + " / " + e.TotalBytesToReceive;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            status.Text = "Hoàn thành!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://drakelam.com/");
            // System.Diagnostics.Process.Start("https://drakelam.com/);
            // using System.Diagnostics;
            // Trong 2 đường dẫn tới địa chỉ web bạn dùng 1trong2 đều được. Và nhớ sử dụng  thư viện System.Diagnostics
        }


    }
}
