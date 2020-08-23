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
    public partial class EditBirthDay : UserControl
    {
        public Account Acc { get; set; }
        public EditBirthDay()
        {
            InitializeComponent();
        }
        public EditBirthDay(Account acc)
        {
            InitializeComponent();
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
            DateTime birthday = dpBirthday.Value;
            Acc.birthday = birthday;
            return Acc;
        }

        private void EditBirthDay_Load(object sender, EventArgs e)
        {
            pnlError.Visible = false;
            if(Acc.birthday!=null)
            {
                dpBirthday.Value = (DateTime)Acc.birthday;
            }
        }
    }
}
