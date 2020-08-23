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

namespace ChatApp.Views.Components
{
    public partial class EditUserName : UserControl
    {
        public Account Acc { get; set; }
        public EditUserName()
        {
            InitializeComponent();
        }
        public EditUserName(Account acc)
        {
            InitializeComponent();
            this.txtFirstName.Text = acc.firstName;
            this.txtLastName.Text = acc.lastName;
            Acc = acc;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void BtnSaveClick(EventHandler e)
        {
            this.btnSave.Click += e;
        }
        public Account GetAccount()
        {
            this.pnlError.Visible = false;
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            if(firstName.Length == 0 || lastName.Length == 0)
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Vui lòng điền đầy đủ thông tin!";
            }else if(firstName.Length < 2)
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Tên họ quá ngắn!";
            }else if(lastName.Length < 2)
            {
                this.pnlError.Visible = true;
                this.lbError.Text = "Tên quá ngắn!";
            }
            if(!this.pnlError.Visible)
            {
                Acc.firstName = firstName;
                Acc.lastName = lastName;
                return Acc;
            }
            return null;
        }

        private void EditUserName_Load(object sender, EventArgs e)
        {
            this.pnlError.Visible = false;
        }
    }
}
