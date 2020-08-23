using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using ChatApp.Utils;
using ReferenceData.Entity;
using ChatApp.Handler;
using Microsoft.VisualBasic.ApplicationServices;
using ReferenceData;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class ChatBox : UserControl
    {
        public Frame Form { get; set; }
        public ReferenceData.Entity.Conversation Conversation { get; set; }
        public List<ReferenceData.Entity.Message> MessageList { get; set; } = new List<ReferenceData.Entity.Message>();
        public ChatClient Client { get; set; }
        public Components.Conversation ConversationBox { get; set; }
        private OutgoingMessage currentOutMessage = null;
        private IncomingMessage currentInMessage = null;
        public FileItem FileItem = null;
        public FlowLayoutPanel FPMessage1 = new FlowLayoutPanel();
        public FlowLayoutPanel FPMessage2 = new FlowLayoutPanel();
        public ChatBox()
        {
            InitializeComponent();
        }
        public ChatBox(Frame form, ReferenceData.Entity.Conversation cvst)
        {
            InitializeComponent();
            Form = form;
            Conversation = cvst;
            this.messageBox.flowLayoutPanel.Padding = new Padding(10, 0, 0, 0);
            FPMessage1.AutoScroll = false;
            FPMessage2.AutoScroll = false;
            FPMessage1.WrapContents = false;
            FPMessage2.WrapContents = false;
            FPMessage1.AutoSize = true;
            FPMessage2.AutoSize = true;
            FPMessage1.FlowDirection = FlowDirection.TopDown;
            FPMessage2.FlowDirection = FlowDirection.BottomUp;
            this.messageBox.flowLayoutPanel.Controls.Add(FPMessage2);
            this.messageBox.flowLayoutPanel.Controls.Add(FPMessage1);
            this.messageBox.UpdateUi();
        }
        private void ChatBox_Load(object sender, EventArgs e)
        {
            this.txtMessage.Focus();
            if (Conversation.memberList.Count <= 2)
            {
                this.btnAddMember.Visible = false;
                this.lbNumMember.Visible = false;
            }
            else
            {
                this.lbNumMember.Text = Conversation.memberList.Count + " Thành viên";
            }
            this.lbTitle.Text = Conversation.title;
            if (Conversation.id != null)
            {
                new LoadMessageHandler(Form.Client).Handle(Conversation.id, 0, 16);
            }
            this.messageBox.VScrollBarValueChanged(new LoadMoreMessageHandler(Form.Client).Handle);
        }
        public void LoadMoreMessage(List<ReferenceData.Entity.Message> list)
        {
            GenarateMessage(list, FPMessage2);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            new SendMessageHandler(this).Handle();
            txtMessage.Focus();
        }
        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                new SendMessageHandler(this).Handle();
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePictureDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif) | *.png;*.jpg;*.jpeg;*.gif",
                Title = "Chọn một file ảnh"
            };
            choosePictureDialog.ShowDialog();
            if (!choosePictureDialog.FileName.Equals(""))
            {
                byte[] file = ChatAppUtils.ConvertFileToByte(choosePictureDialog.FileName);
                string[] arrFileName = choosePictureDialog.FileName.Split('\\');
                string fn = arrFileName[arrFileName.Length - 1];
                if (FileItem != null)
                {
                    this.Controls.Remove(FileItem);
                    FileItem = null;
                }
                FileItem = new FileItem(fn, file);
                this.Controls.Add(FileItem);
                FileItem.Location = new Point(25, 386);
                FileItem.BringToFront();
                FileItem.ButtonCloseClick(closeFileItem);
            }
            this.txtMessage.Focus();
        }
        private void btnChooseAllFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFileDialog = new OpenFileDialog()
            {
                Filter = "Image files (*.*) | *.*",
                Title = "Chọn một file"
            };
            chooseFileDialog.ShowDialog();
            if (!chooseFileDialog.FileName.Equals(""))
            {
                byte[] file = ChatAppUtils.ConvertFileToByte(chooseFileDialog.FileName);
                string[] arrFileName = chooseFileDialog.FileName.Split('\\');
                string fn = arrFileName[arrFileName.Length - 1];
                if (FileItem != null)
                {
                    this.Controls.Remove(FileItem);
                    FileItem = null;
                }
                FileItem = new FileItem(fn, file);
                this.Controls.Add(FileItem);
                FileItem.Location = new Point(25, 386);
                FileItem.BringToFront();
                FileItem.ButtonCloseClick(closeFileItem);
            }
            this.txtMessage.Focus();
        }
        private void closeFileItem(object sender, EventArgs e)
        {
            this.Controls.Remove(FileItem);
            FileItem = null;
            txtMessage.Focus();
        }
        public void ShowErrorSendFile()
        {
            CustomMessageBox mb = new CustomMessageBox();
            mb.show("Dung lượng file quá lớn để gửi!", "Lỗi", CustomMessageBox.MessageBoxButtons.Ok, CustomMessageBox.MessageBoxIcon.Error);
        }
        public void AddOutMessage(ReferenceData.Entity.Message message)
        {
            if (FileItem != null)
            {
                this.Controls.Remove(FileItem);
                FileItem = null;
            }
            currentInMessage = null;
            this.txtMessage.Text = "";
            UserControl bubble = null;
            if (message.messageType.ToUpper().Equals("TEXT"))
            {
                bubble = new TextBubble(message.content, TextBubble.msgType.Out);
            }
            else
            {
                bubble = new FileBubble(message.content, message.file, FileBubble.msgType.Out);
            }
            if (this.currentOutMessage == null)
            {
                currentOutMessage = new OutgoingMessage(Form.User.id, DateTime.Now);
            }
            else
            {
                if (compareTime(currentOutMessage.Time, DateTime.Now))
                {
                    FPMessage1.Controls.Remove(currentOutMessage);
                }
                else
                {
                    currentOutMessage = new OutgoingMessage(Form.User.id, DateTime.Now);
                }
            }
            currentOutMessage.AddBubble(bubble);
            FPMessage1.Controls.Add(currentOutMessage);
            this.messageBox.UpdateUi();
            if (this.messageBox.panelBg.Size.Height < this.messageBox.flowLayoutPanel.PreferredSize.Height)
            {
                this.messageBox.vScrollBar.Value = this.messageBox.vScrollBar.Maximum;
            }

            foreach (var c in Form.ConversationList)
            {
                if (c.Cvst.id.Equals(message.conversationId))
                {
                    Form.InitLatestMessage(c, message);
                    break;
                }
            }
        }
        public void AddInMessage(ReferenceData.Entity.Message message)
        {
            currentOutMessage = null;
            UserControl bubble = null;
            if (message.messageType.ToUpper().Equals("TEXT"))
            {
                bubble = new TextBubble(message.content, TextBubble.msgType.In);
            }
            else
            {
                bubble = new FileBubble(message.content, message.file, FileBubble.msgType.In);
            }
            if (this.currentInMessage == null)
            {
                currentInMessage = new IncomingMessage(message.avatar, message.senderId, message.lastName, DateTime.Now);
            }
            else
            {
                if (currentInMessage.UserId != message.senderId)
                {
                    currentInMessage = new IncomingMessage(message.avatar, message.senderId, message.lastName, DateTime.Now);
                }
                else
                {
                    if (compareTime(currentInMessage.Time, DateTime.Now))
                    {
                        FPMessage1.Controls.Remove(currentInMessage);
                    }
                    else
                    {
                        currentInMessage = new IncomingMessage(message.avatar, message.senderId, message.lastName, DateTime.Now);
                    }
                }
            }
            currentInMessage.AddBubble(bubble);
            FPMessage1.Controls.Add(currentInMessage);
            this.messageBox.UpdateUi();
            if (this.messageBox.panelBg.Size.Height < this.messageBox.flowLayoutPanel.PreferredSize.Height)
            {
                this.messageBox.vScrollBar.Value = this.messageBox.vScrollBar.Maximum;
            }
            foreach (var c in Form.ConversationList)
            {
                if (c.Cvst.id.Equals(message.conversationId))
                {
                    Form.InitLatestMessage(c, message);
                    break;
                }
            }
        }
        private bool compareTime(DateTime t1, DateTime t2)
        {
            if (t1.Year == t2.Year && t1.Month == t2.Month && t1.Day == t2.Day && t1.Hour == t2.Hour && t1.Minute == t2.Minute)
            {
                return true;
            }
            return false;
        }
        public void GenarateMessage(List<ReferenceData.Entity.Message> list, FlowLayoutPanel fl)
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.AutoScroll = false;
            flow.WrapContents = false;
            flow.AutoSize = true;
            if (fl.Equals(FPMessage1))
            {
                list.Reverse();
                flow.FlowDirection = FlowDirection.TopDown;
            } else
            {
                flow.FlowDirection = FlowDirection.BottomUp;
            }

            DateTime time = (DateTime)list[0].createdAt;
            UserControl currentMessage;
            UserControl bubble;
            IncomingMessage cInMessage = new IncomingMessage();
            OutgoingMessage cOutMessage = new OutgoingMessage();
            if (list[0].senderId != Form.User.id)
            {
                cInMessage = new IncomingMessage(list[0].avatar, list[0].senderId, list[0].lastName, time);
                if (list[0].messageType.Equals("FILE"))
                {
                    bubble = new FileBubble(list[0].content, list[0].file, FileBubble.msgType.In);
                }
                else
                {
                    bubble = new TextBubble(list[0].content, TextBubble.msgType.In);
                }
                cInMessage.AddBubble(bubble);
                currentMessage = cInMessage;
            }
            else
            {
                cOutMessage = new OutgoingMessage(list[0].senderId, time);
                if (list[0].messageType.Equals("FILE"))
                {
                    bubble = new FileBubble(list[0].content, list[0].file, FileBubble.msgType.Out);
                }
                else
                {
                    bubble = new TextBubble(list[0].content, TextBubble.msgType.Out);
                }
                cOutMessage.AddBubble(bubble);
                currentMessage = cOutMessage;
            }
            foreach (var mes in list)
            {
                if (!mes.Equals(list[0]))
                {
                    if (mes.senderId != Form.User.id)
                    {
                        if (currentMessage.GetType() != typeof(IncomingMessage))
                        {
                            flow.Controls.Add(currentMessage);
                            time = (DateTime)mes.createdAt;
                            cInMessage = new IncomingMessage(mes.avatar, mes.senderId, mes.lastName, time);
                            if (mes.messageType.Equals("FILE"))
                            {
                                bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.In);
                            }
                            else
                            {
                                bubble = new TextBubble(mes.content, TextBubble.msgType.In);
                            }
                            cInMessage.AddBubble(bubble);
                            currentMessage = cInMessage;
                        }
                        else
                        {
                            if (compareTime(time, (DateTime)mes.createdAt) && cInMessage.UserId == mes.senderId)
                            {
                                if (mes.messageType.Equals("FILE"))
                                {
                                    bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.In);
                                }
                                else
                                {
                                    bubble = new TextBubble(mes.content, TextBubble.msgType.In);
                                }
                                cInMessage.AddBubble(bubble);
                            }
                            else
                            {
                                flow.Controls.Add(currentMessage);
                                time = (DateTime)mes.createdAt;
                                cInMessage = new IncomingMessage(mes.avatar, mes.senderId, mes.lastName, time);
                                if (mes.messageType.Equals("FILE"))
                                {
                                    bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.In);
                                }
                                else
                                {
                                    bubble = new TextBubble(mes.content, TextBubble.msgType.In);
                                }
                                cInMessage.AddBubble(bubble);
                                currentMessage = cInMessage;
                            }
                        }
                    }
                    else
                    {
                        if (currentMessage.GetType() != typeof(OutgoingMessage))
                        {
                            flow.Controls.Add(currentMessage);
                            time = (DateTime)mes.createdAt;
                            cOutMessage = new OutgoingMessage(mes.senderId, time);
                            if (mes.messageType.Equals("FILE"))
                            {
                                bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.Out);
                            }
                            else
                            {
                                bubble = new TextBubble(mes.content, TextBubble.msgType.Out);
                            }
                            cOutMessage.AddBubble(bubble);
                            currentMessage = cOutMessage;
                        }
                        else
                        {
                            if (compareTime(time, (DateTime)mes.createdAt) && cOutMessage.UserId == mes.senderId)
                            {
                                if (mes.messageType.Equals("FILE"))
                                {
                                    bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.Out);
                                }
                                else
                                {
                                    bubble = new TextBubble(mes.content, TextBubble.msgType.Out);
                                }
                                cOutMessage.AddBubble(bubble);
                            }
                            else
                            {
                                flow.Controls.Add(currentMessage);
                                time = (DateTime)mes.createdAt;
                                cOutMessage = new OutgoingMessage(mes.senderId, time);
                                if (mes.messageType.Equals("FILE"))
                                {
                                    bubble = new FileBubble(mes.content, mes.file, FileBubble.msgType.Out);
                                }
                                else
                                {
                                    bubble = new TextBubble(mes.content, TextBubble.msgType.Out);
                                }
                                cOutMessage.AddBubble(bubble);
                                currentMessage = cOutMessage;
                            }
                        }
                    }
                }
            }
            flow.Controls.Add(currentMessage);
            fl.Controls.Add(flow);
            this.messageBox.UpdateUi();
        }

        private void lbNumMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Overlay overlay = new Overlay();
            overlay.Location = new Point(Form.Location.X, Form.Location.Y + 32);
            overlay.Show();
            MemberForm mbf = new MemberForm(Conversation.memberList);
            mbf.ShowDialog();
            overlay.Dispose();
        }
    }
}
