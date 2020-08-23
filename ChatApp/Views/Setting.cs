using ChatApp.Handler;
using ChatApp.Views.Components;
using ReferenceData.Entity;
using ReferenceData.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class Setting : Form
    {
        private Frame form;
        private EditUserName EditName;
        private EditPassword EditPass;
        private EditBirthDay EditBirthday;
        public Setting()
        {
            InitializeComponent();
        }
        public Setting(Frame form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.pbAvatar.Image = ChatAppUtils.ByteToImage(form.User.avatar);
            this.lbFullName.Text = form.User.firstName + " " + form.User.lastName;
            this.lbEmail.Text = form.User.email;
            if (form.User.birthday != null)
            {
                DateTime birthday = (DateTime)form.User.birthday;
                this.lbBirthday.Text = birthday.ToString("dd/MM/yyyy");
            }
            else
            {
                this.lbBirthday.Text = "Thêm ngày sinh";
            }
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            EditName = new EditUserName(form.User);
            this.Controls.Add(EditName);
            EditName.BringToFront();
            EditName.Location = new Point(100, 158);
            EditName.BtnSaveClick(btnChangeNameClick);
        }
        private void btnChangeNameClick(object sender, EventArgs e)
        {
            Account acc = EditName.GetAccount();
            if(acc!=null)
            {
                new UpdateAccountHandler(form.Client).Handle(acc);
                EditName.Dispose();
            }
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            EditPass = new EditPassword(form.User);
            this.Controls.Add(EditPass);
            EditPass.BringToFront();
            EditPass.Location = new Point(100, 158);
            EditPass.BtnSaveClick(btnChangePassClick);
        }
        private void btnChangePassClick(object sender, EventArgs e)
        {
            Account acc = EditPass.GetAccount();
            if (acc != null)
            {
                new UpdateAccountHandler(form.Client).Handle(acc);
                EditPass.Dispose();
            }
        }

        private void btnEditBirthday_Click(object sender, EventArgs e)
        {
            EditBirthday = new EditBirthDay(form.User);
            this.Controls.Add(EditBirthday);
            EditBirthday.BringToFront();
            EditBirthday.Location = new Point(100, 158);
            EditBirthday.BtnSaveClick(btnChangeBirthdayClick);
        }
        private void btnChangeBirthdayClick(object sender, EventArgs e)
        {
            Account acc = EditBirthday.GetAccount();
            new UpdateAccountHandler(form.Client).Handle(acc);
            EditBirthday.Dispose();
        }

        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePictureDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif) | *.png;*.jpg;*.jpeg;*.gif",
                Title = "Chọn một file ảnh"
            };
            choosePictureDialog.ShowDialog();
            if (!choosePictureDialog.FileName.Equals(""))
            {
                Account acc = form.User;
                acc.avatar = ChatAppUtils.ConvertFileToByte(choosePictureDialog.FileName);
                new UpdateAccountHandler(form.Client).Handle(acc);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            CustomMessageBox msb = new CustomMessageBox();
            msb.show("Xác nhận đăng xuất!", "Xác nhận", CustomMessageBox.MessageBoxButtons.YesNo, CustomMessageBox.MessageBoxIcon.Warning);
            int result = msb.Result;
            if(result == 1)
            {
                form.Close();
            }
        }
    }
}
