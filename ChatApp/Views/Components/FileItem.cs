using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ChatApp.Utils;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class FileItem : UserControl
    {
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public FileItem()
        {
            InitializeComponent();
        }

        public FileItem(string fileName, byte[] file)
        {
            File = file;
            FileName = fileName;
            InitializeComponent();
            string[] arrFileName = fileName.Split('.');
            string ex = arrFileName[arrFileName.Length - 1].ToUpper();
            if (ex.Equals("JPG") || ex.Equals("JPEG") || ex.Equals("PNG") || ex.Equals("GIF"))
            {
                this.file.Size = new Size(120, 90);
                this.file.Location = new Point(5, 5);
                this.file.Image = ChatAppUtils.ByteToImage(File);
                this.file.SendToBack();
                this.lbFileName.Visible = false;
                this.lbFileSize.Visible = false;
            }
            else
            {
                this.lbFileName.Text = FileName;
                this.lbFileSize.Text = getFileSize(File);
            }
        }
        public void ButtonCloseClick(EventHandler e)
        {
            this.btnClose.Click += new System.EventHandler(e);
        }
        private string getFileSize(byte[] file)
        {
            string size = "";
            if (file.Length >= 524288)
            {
                double a = ((double)file.Length) / 1048576;
                size = Math.Round(a, 2) + " MB";
            }
            else if (file.Length < 524288 && file.Length >= 512)
            {
                double a = ((double)file.Length) / 1024;
                size = Math.Round(a, 2) + " KB";
            }
            else
            {
                size = file.Length.ToString() + " byte";
            }
            return size;
        }
    }
}
