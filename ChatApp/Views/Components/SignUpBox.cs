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
    public partial class SignUpBox : UserControl
    {
        public SignUpBox()
        {
            InitializeComponent();
        }
        public void BtnSignUpClick(EventHandler e)
        {
            this.btnSignUp.Click += new System.EventHandler(e);
        }
        public void TxtRepasswordKeyUp(KeyEventHandler e)
        {
            this.txtRePassword.KeyUp += e;
        }
        public void LinkToLoginClick(EventHandler e)
        {
            this.linkToLogin.Click += new System.EventHandler(e);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            if (firstName.Equals("") || lastName.Equals(""))
            {
                pnlError.Visible = true;
                lbError.Text = "Vui lòng điền đầy đủ thông tin.";
            }
            else
            {
                pnlError.Visible = false;
                this.panel1.BringToFront();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panel2.BringToFront();
            this.pnlError.Visible = false;
        }

        public bool CheckSignUp()
        {
            pnlError.Visible = false;
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string rePassword = txtRePassword.Text.Trim();
            string emailRegex = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?!-)(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            if (email.Equals("") || password.Equals("") || rePassword.Equals(""))
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
                else if (password.Length < 6)
                {
                    pnlError.Visible = true;
                    lbError.Text = "Mật khẩu phải dài hơn 5 ký tự.";
                }
                else if (!password.Equals(rePassword))
                {
                    pnlError.Visible = true;
                    lbError.Text = "Không khớp mật khẩu.";
                }
            }
            if (!pnlError.Visible)
            {
                return true;
            }
            return false;
        }

        private void txtFirstName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = txtFirstName.Text.Trim();
                if (str.Length > 0)
                {
                    txtLastName.Focus();
                }
            }
        }

        private void txtLastName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                if (firstName.Equals("") || lastName.Equals(""))
                {
                    pnlError.Visible = true;
                    lbError.Text = "Vui lòng điền đầy đủ thông tin.";
                }
                else
                {
                    pnlError.Visible = false;
                    this.panel1.BringToFront();
                    txtEmail.Focus();
                }
            }
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

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string str = txtPassword.Text.Trim();
                if (str.Length > 0)
                {
                    txtRePassword.Focus();
                }
            }
        }

        private void SignUpBox_Load(object sender, EventArgs e)
        {
            pnlError.Visible = false;
            txtFirstName.Focus();
        }
    }
}
