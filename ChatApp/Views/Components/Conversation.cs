using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class Conversation : UserControl
    {
        public ReferenceData.Entity.Conversation Cvst { get; set; }
        public ReferenceData.Entity.Account Acc { get; set; }

        public Conversation()
        {
            InitializeComponent();
        }

        public Conversation(ReferenceData.Entity.Conversation conversation, ReferenceData.Entity.Account acc)
        {
            InitializeComponent();
            Cvst = conversation;
            Acc = acc;
        }

        private void initUi()
        {
            unReadMessage.Visible = false;
            if (!Cvst.state && Cvst.memberList.Count == 2)
            {
                this.btnState.FillColor = System.Drawing.Color.LightSteelBlue;
            }
            if (Cvst.creatorId != Acc.id && Cvst.memberList.Count == 2)
            {
                foreach (var mb in Cvst.memberList)
                {
                    if (mb.id == Cvst.creatorId)
                    {
                        this.lbTitle.Text = mb.firstName + " " + mb.lastName;
                        this.pbAvatar.Image = ChatAppUtils.ByteToImage(mb.avatar);
                        break;
                    }
                }
            }
            else
            {
                this.lbTitle.Text = Cvst.title;
                if(Cvst.avatar != null)
                {
                    this.pbAvatar.Image = ChatAppUtils.ByteToImage(Cvst.avatar);
                }
            }
            DateTime time = (DateTime)Cvst.createdAt;
            this.lbDate.Text = time.ToString("HH:mm dd/MM/yyyy");
        }
        public void InitLatestMessage()
        {
            if (Cvst.messageType.Equals("FILE"))
            {
                if (Cvst.senderId != Acc.id)
                {
                    foreach (var u in Cvst.memberList)
                    {
                        if (u.id == Cvst.senderId)
                        {
                            string[] arr = Cvst.content.Split('_');
                            string fex = arr[arr.Length - 1];
                            if (fex.Equals(".jpg") || fex.Equals(".png") || fex.Equals(".jpeg") || fex.Equals(".gif"))
                            {
                                this.lbLatestMessage.Text = u.lastName + " đã gửi một ảnh.";
                            }
                            else
                            {
                                this.lbLatestMessage.Text = u.lastName + " đã gửi một file.";
                            }
                        }
                    }
                }
                else
                {
                    string[] arr = Cvst.content.Split('_');
                    string fex = arr[arr.Length - 1];
                    if (fex.Equals(".jpg") || fex.Equals(".png") || fex.Equals(".jpeg") || fex.Equals(".gif"))
                    {
                        this.lbLatestMessage.Text = "Bạn đã gửi một ảnh.";
                    } else
                    {
                        this.lbLatestMessage.Text = "Bạn đã gửi một file.";
                    }
                }
            }
            else
            {
                if (Cvst.senderId != Acc.id)
                {
                    foreach (var u in Cvst.memberList)
                    {
                        if (u.id == Cvst.senderId)
                        {
                            this.lbLatestMessage.Text = u.lastName + ": " + Cvst.content;
                        }
                    }
                }
                else
                {
                    this.lbLatestMessage.Text = "Bạn: " + Cvst.content;
                }
            }
        }

        public void ConversationClick(EventHandler e)
        {
            this.btnState.Click += new System.EventHandler(e);
            this.lbDate.Click += new System.EventHandler(e);
            this.bg.Click += new System.EventHandler(e);
            this.unReadMessage.Click += new System.EventHandler(e);
            this.pbAvatar.Click += new System.EventHandler(e);
            this.lbTitle.Click += new System.EventHandler(e);
            this.lbLatestMessage.Click += new System.EventHandler(e);
        }

        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Conversation))
            {
                return false;
            }
            Conversation other = (Conversation)obj;
            if ((this.Cvst.id == null && other.Cvst.id != null) || (this.Cvst.id != null && !this.Cvst.id.Equals(other.Cvst.id)))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            int hash = 0;
            hash += (Cvst.id != null ? Cvst.id.GetHashCode() : 0);
            return hash;
        }

        private void Conversation_Load(object sender, EventArgs e)
        {
            initUi();
            if (Cvst.messageType != null)
            {
                InitLatestMessage();
            }
        }
    }
}
