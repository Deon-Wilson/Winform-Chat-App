using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceData.Entity;
using Microsoft.VisualBasic.ApplicationServices;

namespace ChatApp.Views.Components
{
    public partial class EditPassword : UserControl
    {
        public Account Acc { get; set; }
        public EditPassword()
        {
            InitializeComponent();
        }
        public EditPassword(Account acc)
        {
            InitializeComponent();
            Acc = acc;
        }
        public void BtnSaveClick(EventHandler e)
        {
            this.btnSave.Click += e;
        }
        public Account GetAccount()
        {
            this.pnlError.Visible = false;
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string reNewPass = txtReNewPass.Text.Trim();
            if (oldPass.Length == 0 || newPass.Length == 0 || reNewPass.Length == 0)
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Vui lòng điền đầy đủ thông tin!";
            }
            else if (!Acc.password.Equals(oldPass))
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Không đúng mật khẩu!";
            }
            else if (!newPass.Equals(reNewPass))
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Nhập lại mật khẩu không khớp!";
            }
            if (!this.pnlError.Visible)
            {
                Acc.password = newPass;
                return Acc;
            }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            pnlError.Visible = false;
        }
    }
}
