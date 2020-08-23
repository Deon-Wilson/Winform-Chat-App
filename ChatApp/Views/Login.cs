using ChatApp.Handler;
using ChatApp.Views.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class Login : Form
    {
        public SignUpBox SignUpBox { get; set; }
        public LoginBox LoginBox { get; set; }
        int pbHeight;
        bool collapse;
        public Login()
        {
            InitializeComponent();
            this.getStarted.SignInOrCreateClick(signInOrCreate_Click);
            pbHeight = pbLogo.Height;
            collapse = false;
        }
        public void addSignUpBox()
        {
            SignUpBox = new SignUpBox();
            this.pnlPages.Controls.Add(SignUpBox);
            SignUpBox.Location = new Point(0, 0);
            SignUpBox.LinkToLoginClick(linkToLogin_Click);
            SignUpBox.BtnSignUpClick(new SignUpHandler(this).Handle);
            SignUpBox.TxtRepasswordKeyUp(new SignUpHandler(this).Handle2);
        }
        public void addLoginBox()
        {
            LoginBox = new LoginBox();
            this.pnlPages.Controls.Add(LoginBox);
            LoginBox.Location = new Point(0, 0);
            LoginBox.LinkToSignUpClick(linkToSignUp_Click);
            LoginBox.BtnLoginClick(new SignInHandler(this).Handle);
            LoginBox.TxtPasswordEnter(new SignInHandler(this).Handle2);
        }
        private void signInOrCreate_Click(object sender, EventArgs e)
        {
            timer.Start();
            this.pnlPages.Controls.Clear();
            addLoginBox();
        }
        
        private void linkToSignUp_Click(object sender, EventArgs e)
        {
            this.pnlPages.Controls.Clear();
            addSignUpBox();
        }
       
        private void linkToLogin_Click(object sender, EventArgs e)
        {
            this.pnlPages.Controls.Clear();
            addLoginBox();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if(collapse)
            {
                pbLogo.Height = pbLogo.Height + 5;
                if(pbLogo.Height >= pbHeight)
                {
                    timer.Stop();
                    collapse = false;
                    this.Refresh();
                }
            } else
            {
                pbLogo.Height = pbLogo.Height - 5;
                if(pbLogo.Height <= 100)
                {
                    timer.Stop();
                    collapse = true;
                    this.Refresh();
                }
            }
        }
    }
}
