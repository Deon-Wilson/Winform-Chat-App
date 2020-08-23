using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class CustomMessageBox : Form
    {
        private Color INFO_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(85)))), ((int)(((byte)(204)))));
        private Color SUCCESS_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(188)))), ((int)(((byte)(61)))));
        private Color WARNING_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
        private Color ERROR_COLOR = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        private Image INFO_IMAGE = global::ChatApp.Properties.Resources.info;
        private Image SUCCESS_IMAGE = global::ChatApp.Properties.Resources.success;
        private Image WARNING_IMAGE = global::ChatApp.Properties.Resources.warning;
        private Image ERROR_IMAGE = global::ChatApp.Properties.Resources.error;

        public int Result { get; set; }

        public enum MessageBoxButtons
        {
            YesNo = 0,
            Ok = 1
        }
        public enum MessageBoxIcon
        {
            Info = 0,
            Success = 1,
            Warning = 2,
            Error = 3
        }
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        
        public void show(string msg)
        {
            init(msg, "", INFO_COLOR, INFO_IMAGE, false, false, true);
        }

        public void show(string msg, string title)
        {
            init(msg, title, INFO_COLOR, INFO_IMAGE, false, false, true);
        }
        public void show(string msg, string title, MessageBoxButtons btn)
        {
            if(MessageBoxButtons.Ok == btn)
            {
                init(msg, title, INFO_COLOR, INFO_IMAGE, false, false, true);
            } else if(MessageBoxButtons.YesNo == btn)
            {
                init(msg, title, INFO_COLOR, INFO_IMAGE, true, true, false);
            }
        }

        public void show(string msg, string title, MessageBoxButtons btn, MessageBoxIcon icon)
        {
            Color color = INFO_COLOR;
            Image image = INFO_IMAGE;
            bool btnNoVisible = true;
            bool btnYesVisible = true; 
            bool btnOkVisible = true;
            if (MessageBoxButtons.Ok == btn)
            {
                btnNoVisible = false;
                btnYesVisible = false;
            }
            else if (MessageBoxButtons.YesNo == btn)
            {
                btnOkVisible = false;
            }
            if(MessageBoxIcon.Success == icon)
            {
                color = SUCCESS_COLOR;
                image = SUCCESS_IMAGE;
            }
            else if(MessageBoxIcon.Warning == icon)
            {
                color = WARNING_COLOR;
                image = WARNING_IMAGE;
            } else if(MessageBoxIcon.Error == icon)
            {
                color = ERROR_COLOR;
                image = ERROR_IMAGE;
            }
            init(msg, title, color, image, btnNoVisible, btnYesVisible, btnOkVisible);
        }

        private void init(string msg,string title,Color color, Image image, bool btnNoVisible, bool btnYesVisible, bool btnOkVisible)
        {
            Result = 0;
            this.lbMsg.Text = msg;
            this.lbTitle.Text = title;
            this.pbIcon.Image = image;
            this.messageBoxIcon.Image = image;
            this.panelTop.BackColor = color;
            this.btnNo.FillColor = color;
            this.btnYes.FillColor = color;
            this.btnOk.FillColor = color;
            this.btnOk.Visible = btnOkVisible;
            this.btnNo.Visible = btnNoVisible;
            this.btnYes.Visible = btnYesVisible;
            this.ShowDialog();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Result = 1;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Result = 0;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
