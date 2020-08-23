using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChatApp.Views.Components
{
    public partial class LoginBox : UserControl
    {
        public LoginBox()
        {
            InitializeComponent();
        }
        public void BtnLoginClick(EventHandler e)
        {
            this.btnLogin.Click += new System.EventHandler(e);
        }
        public bool CheckSignIn()
        {
            pnlError.Visible = false;
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string emailRegex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?!-)(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            if (email.Equals("") || password.Equals(""))
            {
                pnlError.Visible = true;
                lbError.Text = "Vui lòng điền đây đủ thông tin.";
            }
            else
            {
                if (!Regex.IsMatch(email, emailRegex))
                {
                    pnlError.Visible = true;
                    lbError.Text = "Không đúng định dạng email.";
                }
            }
            if (!pnlError.Visible)
            {
                return true;
            }
            return false;
        }
        public void LinkToSignUpClick(EventHandler e)
        {
            this.linkToSignUp.Click += new System.EventHandler(e);
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = txtEmail.Text.Trim();
                if (str.Length > 0)
                {
                    txtPassword.Focus();
                }
            }
        }
        public void TxtPasswordEnter(KeyEventHandler e)
        {
            this.txtPassword.KeyUp += e;
        }

        private void LoginBox_Load(object sender, EventArgs e)
        {
            this.pnlError.Visible = false;
            this.txtEmail.Focus();
        }
    }
}
