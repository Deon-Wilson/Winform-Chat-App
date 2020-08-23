using ChatApp.Handler;
using ChatApp.Views.Components;
using ReferenceData.Entity;
using ReferenceData.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class AddNewGroup : Form
    {
        public string GroupName { get; set; } = null;
        public string AvatarName { get; set; } = "groupavatar.png";
        public byte[] Avatar { get; set; } = null;
        private Frame form;
        public List<GroupMember> MemberList { get; set; } = new List<GroupMember>();
        public AddNewGroup()
        {
            InitializeComponent();
        }
        public AddNewGroup(Frame form)
        {
            InitializeComponent();
            this.form = form;
            this.pnlConversation.flowLayoutPanel.Padding = new Padding(16, 0, 0, 0);
            this.pnlMember.flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            this.pnlMember.flowLayoutPanel.WrapContents = true;
        }
        public void DisplayDefaultList()
        {
            this.pnlConversation.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.pnlConversation.flowLayoutPanel.Controls.Clear();
            foreach (var c in form.ConversationList)
            {
                if (c.Cvst.memberList.Count == 2)
                {
                    foreach (var u in c.Cvst.memberList)
                    {
                        if (u.id != c.Acc.id)
                        {
                            SearchResult sr = new SearchResult(u);
                            sr.Size = new Size(410, 62);
                            this.pnlConversation.flowLayoutPanel.Controls.Add(sr);
                            sr.SearchResultClick(new SelectMemberHandler(this, sr.Account).HandleAdd);
                        }
                    }

                }
            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            pnlLast.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFirst.BringToFront();
        }

        private void txtGroupName_KeyUp(object sender, KeyEventArgs e)
        {
            string groupName = txtGroupName.Text.Trim();
            if(groupName.Length > 0)
            {
                btnContinue.Enabled = true;
                GroupName = groupName;
            } else
            {
                btnContinue.Enabled = false;
                GroupName = null;
            }
        }

        private void AddNewGroup_Load(object sender, EventArgs e)
        {
            DisplayDefaultList();
        }
        public void AddMember(Account acc) 
        {
            GroupMember mb = new GroupMember(acc);
            MemberList.Add(mb);
            this.pnlMember.flowLayoutPanel.Controls.Add(mb);
            mb.BtnRemoveClick(new SelectMemberHandler(this, acc).HandleRemove);
            this.pnlMember.UpdateUi();
            if(MemberList.Count >= 2)
            {
                this.btnCreateGroup.Enabled = true;
            }
        }
        public void RemoveMember(Account acc)
        {
            foreach(var mb in MemberList)
            {
                if(mb.Acc.id == acc.id)
                {
                    this.pnlMember.flowLayoutPanel.Controls.Remove(mb);
                    MemberList.Remove(mb);
                    break;
                }
            }
            this.pnlMember.UpdateUi();
            if (MemberList.Count < 2)
            {
                this.btnCreateGroup.Enabled = false;
            }
        }
        public void BtnCreateGroupClick(EventHandler e)
        {
            this.btnCreateGroup.Click += e;
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
                Avatar = ChatAppUtils.ConvertFileToByte(choosePictureDialog.FileName);
                string[] arrFileName = choosePictureDialog.FileName.Split('\\');
                AvatarName = arrFileName[arrFileName.Length - 1];
                pbGroupAvatar.Image = ChatAppUtils.ByteToImage(Avatar);
            }
        }
    }
}
