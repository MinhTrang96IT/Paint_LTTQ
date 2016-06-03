using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmUploadFacebook : Form
    {
        public frmUploadFacebook()
        {
            InitializeComponent();

            txtTenFile.Text = strFileName;
        }

        private bool isCompleted = false;

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private string RandomString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string GetFileType(string input)
        {
            return "." + input.Split('.').Last();
        }

        public static string strFileName;

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image File|*.jpg;*.png;*.gif";
            if (of.ShowDialog() == DialogResult.OK)
            {
                // txtTenFile.Text = of.FileName;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtTenFile.Text != "")
            {
                btnSend.Text = "Uploading...";
                btnSend.Enabled = false;
                progressBar1.Style = ProgressBarStyle.Marquee;
                isCompleted = false;

                System.Threading.Thread t = new System.Threading.Thread(() =>
                {
                    string RanFileName = RandomString() + GetFileType(txtTenFile.Text); //Random filename - tránh trùng tên
                    string url = "http://kawaii15-vngirl.rhcloud.com/Upimg/upload.php"; //địa chỉ file PHP

                    //  AppDomain.CurrentDomain.BaseDirectory: Tìm ra đường dẫn của file .exe
                    File.Copy(txtTenFile.Text, AppDomain.CurrentDomain.BaseDirectory + "/" + RanFileName); //chép file qua thư mục tạm
                    // Mở kết nối. 
                    WebClient client = new WebClient();
                    // 
                    client.UploadFile(url, "POST", AppDomain.CurrentDomain.BaseDirectory + "/" + RanFileName); // UploadFIle

                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/" + RanFileName); // Xóa file tạm

                    Process.Start("https://www.facebook.com/sharer/sharer.php?u=http://kawaii15-vngirl.rhcloud.com/Upimg/uploads/" + RanFileName); // Khởi động URL chia sẻ
                    isCompleted = true;
                });
                t.Start();
                while (isCompleted != true) // Chờ upload xong
                {
                    Application.DoEvents();
                }
                btnSend.Text = "Send";
                btnSend.Enabled = true;
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                MessageBox.Show("Choose IMG");
            }
        }
    }
}
