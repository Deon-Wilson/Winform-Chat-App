using ChatApp.Utils;
using ChatApp.Views;
using ReferenceData;
using ReferenceData.Entity;
using System;
using System.Windows.Forms;

namespace ChatApp.Handler
{
    public class SignUpHandler
    {
        private Login form;
        public ChatClient client { get; set; }
        public SignUpHandler(Login form)
        {
            this.form = form;
            client = new ChatClient("127.0.0.1", 6868);
        }

        public void Handle(object sender, EventArgs e)
        {
            if (form.SignUpBox.CheckSignUp())
            {
                client.Connect();
                if (client.IsConnected)
                {
                    Account acc = new Account();
                    acc.email = form.SignUpBox.txtEmail.Text;
                    acc.password = form.SignUpBox.txtPassword.Text;
                    acc.firstName = form.SignUpBox.txtFirstName.Text;
                    acc.lastName = form.SignUpBox.txtLastName.Text;
                    CustomMessageBox msb = new CustomMessageBox();
                    if (client.SignUp(new SocketData("SIGNUP", acc)))
                    {
                        client.Close();
                        msb.show("Đăng ký thành công", "Thành công", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Success);
                        form.pnlPages.Controls.Clear();
                        form.addLoginBox();
                    }
                    else
                    {
                        client.Close();
                        form.SignUpBox.pnlError.Visible = true;
                        form.SignUpBox.lbError.Text = "Email đã tồn tại.";
                    }
                }
                else
                {
                    CustomMessageBox msb = new CustomMessageBox();
                    msb.show("Lỗi kết nối!", "Lỗi", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Error);
                }
            }
        }
        public void Handle2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (form.SignUpBox.CheckSignUp())
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        Account acc = new Account();
                        acc.email = form.SignUpBox.txtEmail.Text;
                        acc.password = form.SignUpBox.txtPassword.Text;
                        acc.firstName = form.SignUpBox.txtFirstName.Text;
                        acc.lastName = form.SignUpBox.txtLastName.Text;
                        CustomMessageBox msb = new CustomMessageBox();
                        if (client.SignUp(new SocketData("SIGNUP", acc)))
                        {
                            client.Close();
                            msb.show("Đăng ký thành công", "Thành công", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Success);
                            form.pnlPages.Controls.Clear();
                            form.addLoginBox();
                        }
                        else
                        {
                            client.Close();
                            form.SignUpBox.pnlError.Visible = true;
                            form.SignUpBox.lbError.Text = "Email đã tồn tại.";
                        }
                    }
                    else
                    {
                        CustomMessageBox msb = new CustomMessageBox();
                        msb.show("Lỗi kết nối!", "Lỗi", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
