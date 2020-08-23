using ChatApp.Utils;
using ChatApp.Views;
using ReferenceData;
using ReferenceData.Entity;
using System;
using System.Windows.Forms;

namespace ChatApp.Handler
{
    public class SignInHandler
    {
        private Login form;
        public ChatClient client { get; set; }

        public SignInHandler(Login form)
        {
            this.form = form;
            client = new ChatClient("127.0.0.1", 6868);
        }

        public void Handle(object sender, EventArgs e)
        {
            if (form.LoginBox.CheckSignIn())
            {
                client.Connect();
                if (client.IsConnected)
                {
                    Account acc = new Account();
                    acc.email = form.LoginBox.txtEmail.Text;
                    acc.password = form.LoginBox.txtPassword.Text;
                    Account user = client.SignIn(new SocketData("SIGNIN", acc));
                    if (user != null)
                    {
                        form.Hide();
                        new Frame(client, user).Show();
                    }
                    else
                    {
                        form.LoginBox.pnlError.Visible = true;
                        form.LoginBox.lbError.Text = "Không đúng email hoặc mật khẩu.";
                        client.Close();
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
                if (form.LoginBox.CheckSignIn())
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        Account acc = new Account();
                        acc.email = form.LoginBox.txtEmail.Text;
                        acc.password = form.LoginBox.txtPassword.Text;
                        Account user = client.SignIn(new SocketData("SIGNIN", acc));
                        if (user != null)
                        {
                            form.Hide();
                            new Frame(client, user).Show();
                        }
                        else
                        {
                            form.LoginBox.pnlError.Visible = true;
                            form.LoginBox.lbError.Text = "Không đúng email hoặc mật khẩu.";
                            client.Close();

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
