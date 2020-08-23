using ChatApp.Handler;
using ChatApp.Utils;
using ChatApp.Views.Components;
using ReferenceData.Entity;
using ReferenceData.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class Frame : Form
    {
        public Setting Setting { get; set; } = null;
        public AddNewChat NewChat { get; set; } = null;
        public AddNewGroup NewGroup { get; set; } = null;
        public ChatBox ChatBox { get; set; } = null;
        private Components.Conversation currentConversation = null;
        public ChatClient Client { get; set; }
        public Account User { get; set; }
        public List<Components.Conversation> ConversationList = new List<Components.Conversation>();
        FlowLayoutPanel PnlConversation1 = new FlowLayoutPanel();
        FlowLayoutPanel PnlConversation2 = new FlowLayoutPanel();
        public Frame(ChatClient client, Account user)
        {
            InitializeComponent();
            Client = client;
            User = user;
        }


        public void ResetCurrentConversation()
        {
            if (currentConversation != null)
            {
                currentConversation.bg.FillColor = Color.FromArgb(16, 22, 37);
                currentConversation.bg.FillColor2 = Color.FromArgb(16, 22, 37);
                currentConversation = null;
            }
        }
        public void DisplaySearchResult(List<Account> list)
        {
            PnlConversation1.Controls.Clear();
            PnlConversation2.Controls.Clear();
            foreach (var acc in list)
            {
                if (acc.id != User.id)
                {
                    SearchResult searchResult = new SearchResult(acc);
                    PnlConversation1.Controls.Add(searchResult);
                    searchResult.SearchResultClick(new SearchResultClickHandler(this, acc).Handle);
                }
            }
            pnlConversations.UpdateUi();
        }
        public void DisplayNewConversation()
        {
            PnlConversation2.Controls.Add(ConversationList.Last());
            pnlConversations.UpdateUi();
            pnlConversations.vScrollBar.Value = 0;
        }
        public void DisplayConversations()
        {
            ConversationList.Reverse();
            txtSearchAccount.Text = "";
            PnlConversation1.Controls.Clear();
            PnlConversation2.Controls.Clear();
            foreach (var cvst in ConversationList)
            {
                PnlConversation1.Controls.Add(cvst);
            }
            pnlConversations.UpdateUi();
            pnlConversations.vScrollBar.Value = 0;
        }
        public void AddConversationList(List<ReferenceData.Entity.Conversation> list)
        {
            foreach (var c in list)
            {
                Components.Conversation cvst = new Components.Conversation(c, User);
                cvst.ConversationClick(new OpenConversationHandler(this, cvst).Handle);
                ConversationList.Add(cvst);
            }
            DisplayConversations();
        }
        public void InsertConversationList(ReferenceData.Entity.Conversation cv)
        {
            Components.Conversation cvst = new Components.Conversation(cv, User);
            cvst.ConversationClick(new OpenConversationHandler(this, cvst).Handle);
            ConversationList.Add(cvst);
        }
        public void AddChatBox(ReferenceData.Entity.Conversation cvst)
        {
            if(ChatBox == null || ChatBox.Conversation.id != currentConversation.Cvst.id || cvst.id == null)
            {
                this.pnlPages.Controls.Clear();
                ChatBox = new ChatBox(this, cvst);
                this.pnlPages.Controls.Add(ChatBox);
                ChatBox.Location = new Point(0, 0);
            }
        }
        public void SelectConversation(ReferenceData.Entity.Conversation cv)
        {
            foreach (var cvst in ConversationList)
            {
                if (cvst.Cvst.Equals(cv))
                {
                    if (!cvst.Equals(this.currentConversation))
                    {
                        if (this.currentConversation == null)
                        {
                            this.currentConversation = cvst;
                        }
                        else
                        {
                            this.currentConversation.bg.FillColor = Color.FromArgb(16, 22, 37);
                            this.currentConversation.bg.FillColor2 = Color.FromArgb(16, 22, 37);
                            this.currentConversation = cvst;
                        }
                        this.currentConversation.bg.FillColor = Color.FromArgb(250, 48, 90);
                        this.currentConversation.bg.FillColor2 = Color.FromArgb(128, 36, 206);
                    }
                    break;
                }
            }

        }
        public void InitLatestMessage(Components.Conversation cvst, ReferenceData.Entity.Message message)
        {
            if (message.messageType.Equals("FILE"))
            {
                string[] arr = message.content.Split('_');
                string fex = arr[arr.Length - 1];
                if (fex.Equals(".jpg") || fex.Equals(".png") || fex.Equals(".jpeg") || fex.Equals(".gif"))
                {
                    cvst.lbLatestMessage.Text = (message.senderId != cvst.Acc.id ? message.lastName : "Bạn") + " đã gửi một ảnh.";
                }
                else
                {
                    cvst.lbLatestMessage.Text = (message.senderId != cvst.Acc.id ? message.lastName : "Bạn") + " đã gửi một file.";
                }
            }
            else
            {
                cvst.lbLatestMessage.Text = (message.senderId != cvst.Acc.id ? message.lastName : "Bạn") + ": " + message.content;
            }
            DateTime time = (DateTime)message.createdAt;
            cvst.lbDate.Text = time.ToString("HH:mm dd/MM/yyyy");
        }
        public void Online(Account acc)
        {
            foreach (var c in ConversationList)
            {
                if (c.Cvst.memberList.Count == 2)
                {
                    foreach (var mb in c.Cvst.memberList)
                    {
                        if (mb.id == acc.id)
                        {
                            c.btnState.FillColor = Color.Lime;
                        }
                    }
                }
            }
        }
        public void Offline(Account acc)
        {
            foreach (var c in ConversationList)
            {
                if (c.Cvst.memberList.Count == 2)
                {
                    foreach (var mb in c.Cvst.memberList)
                    {
                        if (mb.id == acc.id)
                        {
                            c.btnState.FillColor = Color.LightSteelBlue;
                        }
                    }
                }
            }
        }

        private void txtSearchAccount_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = this.txtSearchAccount.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                new SearchAccountHandler(this).Handle(keyword);
            }
            if (keyword.Length == 0)
            {
                DisplayConversations();
            }
        }

        private void Frame_Load(object sender, EventArgs e)
        {
            this.lbUserName.Text = User.firstName + " " + User.lastName;
            this.pbUserAvatar.Image = ChatAppUtils.ByteToImage(User.avatar);

            PnlConversation1.AutoScroll = false;
            PnlConversation2.AutoScroll = false;
            PnlConversation1.WrapContents = false;
            PnlConversation2.WrapContents = false;
            PnlConversation1.AutoSize = true;
            PnlConversation2.AutoSize = true;
            PnlConversation1.FlowDirection = FlowDirection.TopDown;
            PnlConversation2.FlowDirection = FlowDirection.BottomUp;
            pnlConversations.flowLayoutPanel.Controls.Add(PnlConversation2);
            pnlConversations.flowLayoutPanel.Controls.Add(PnlConversation1);
            pnlConversations.UpdateUi();

            this.pnlPages.Controls.Clear();
            WelcomeBox welcomeBox = new WelcomeBox(User);
            this.pnlPages.Controls.Add(welcomeBox);
            welcomeBox.BtnconversationClick(btnAddNewChat_Click);
            welcomeBox.Location = new Point(0, 0);
            Client.startReadResponse(new ReadResponseHandler(this));
        }

        private void btnAddNewChat_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(this.Location.X, this.Location.Y + 32);
            overlay.Show();
            NewChat = new AddNewChat(this);
            NewChat.ShowDialog();
            overlay.Dispose();
            NewChat = null;
        }

        private void btnAddNewGroup_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(this.Location.X, this.Location.Y + 32);
            overlay.Show();
            NewGroup = new AddNewGroup(this);
            NewGroup.BtnCreateGroupClick(new AddGroupHandler(this).Handle);
            NewGroup.ShowDialog();
            overlay.Dispose();
            NewGroup = null;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(this.Location.X, this.Location.Y + 32);
            overlay.Show();
            Setting = new Setting(this);
            Setting.ShowDialog();
            overlay.Dispose();
            Setting = null;
        }
        public void SuccessUpdate(Account acc)
        {
            if (Setting != null)
            {
                Setting.lbEmail.Text = acc.email;
                Setting.lbFullName.Text = acc.firstName + " " + acc.lastName;
                if (acc.birthday != null)
                {
                    DateTime birthday = (DateTime)acc.birthday;
                    Setting.lbBirthday.Text = birthday.ToString("dd/MM/yyyy");
                }
                Setting.pbAvatar.Image = ChatAppUtils.ByteToImage(acc.avatar);
            }
            this.pbUserAvatar.Image = ChatAppUtils.ByteToImage(acc.avatar);
            this.lbUserName.Text = acc.firstName + " " + acc.lastName;
        }
        public void FailUpdate()
        {
            CustomMessageBox msb = new CustomMessageBox();
            msb.show("Cập nhật không thành công!", "Không thành công", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Error);
        }

        private void Frame_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Client.SignOut(User);
        }
        private void Frame_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Restart();
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
