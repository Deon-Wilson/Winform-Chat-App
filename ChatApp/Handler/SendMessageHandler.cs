using ChatApp.Views.Components;
using System;
using System.Collections.Generic;

namespace ChatApp.Handler
{
    public class SendMessageHandler
    {
        private ChatBox chatBox;

        private delegate void VoidDelegate();
        public SendMessageHandler(ChatBox chatBox)
        {
            this.chatBox = chatBox;
        }
        public void Handle()
        {
            List<ReferenceData.Entity.Message> mesList = new List<ReferenceData.Entity.Message>();
            int a = 0;
            string textMsg = this.chatBox.txtMessage.Text.Trim();
            if (this.chatBox.Conversation.id == null)
            {
                this.chatBox.Conversation.id = "conversation" + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                a = 1;
            }
            int b = 1;
            if (this.chatBox.FileItem != null)
            {
                if (this.chatBox.FileItem.File.Length <= 5242880)
                {
                    string[] fileInfo = getFileInfo(this.chatBox.FileItem.FileName);
                    ReferenceData.Entity.Message fileMessage = new ReferenceData.Entity.Message();
                    fileMessage.id = "" + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                    fileMessage.conversationId = this.chatBox.Conversation.id;
                    fileMessage.senderId = this.chatBox.Form.User.id;
                    if (fileInfo[0].Length == this.chatBox.FileItem.FileName.Length)
                    {
                        fileMessage.content = fileInfo[0] + "_" + fileMessage.id;
                    }
                    else
                    {
                        fileMessage.content = fileInfo[0] + "_" + fileMessage.id + "_." + fileInfo[1];
                    }
                    fileMessage.file = this.chatBox.FileItem.File;
                    fileMessage.messageType = "FILE";
                    fileMessage.firstName = this.chatBox.Form.User.firstName;
                    fileMessage.lastName = this.chatBox.Form.User.lastName;
                    fileMessage.avatar = this.chatBox.Form.User.avatar;
                    fileMessage.createdAt = DateTime.Now;
                    fileMessage.Conversation = this.chatBox.Conversation;
                    this.chatBox.Conversation.createdAt = DateTime.Now;
                    this.chatBox.Conversation.messageType = "FILE";
                    this.chatBox.Conversation.content = fileMessage.content;
                    this.chatBox.AddOutMessage(fileMessage);
                    mesList.Add(fileMessage);
                }
                else
                {
                    this.chatBox.Invoke(new VoidDelegate(this.chatBox.ShowErrorSendFile), new object[] { });
                    b = 0;
                }
            }
            if (!textMsg.Equals("") && b != 0)
            {
                ReferenceData.Entity.Message textMessage = new ReferenceData.Entity.Message();
                textMessage.id = "" + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                textMessage.conversationId = this.chatBox.Conversation.id;
                textMessage.senderId = this.chatBox.Form.User.id;
                textMessage.content = textMsg;
                textMessage.messageType = "TEXT";
                textMessage.firstName = this.chatBox.Form.User.firstName;
                textMessage.lastName = this.chatBox.Form.User.lastName;
                textMessage.avatar = this.chatBox.Form.User.avatar;
                textMessage.createdAt = DateTime.Now;
                textMessage.Conversation = this.chatBox.Conversation;
                this.chatBox.Conversation.createdAt = DateTime.Now;
                this.chatBox.Conversation.messageType = "TEXT";
                this.chatBox.Conversation.content = textMsg;
                this.chatBox.AddOutMessage(textMessage);
                mesList.Add(textMessage);
            }
            if (a == 1)
            {
                insertConversation();
            }
            if(mesList.Count > 0)
            {
                if (a == 1)
                {
                    this.chatBox.Form.InsertConversationList(this.chatBox.Conversation);
                    this.chatBox.Form.DisplayNewConversation();
                    this.chatBox.Form.SelectConversation(this.chatBox.Conversation);
                }
                new InsertMessageHandler(this.chatBox.Form.Client).Handle(mesList);
            }
        }
        

        private string[] getFileInfo(string fileName)
        {
            string[] info = new string[] { "", "" };
            string[] arrName = fileName.Split('.');
            if (arrName.Length >= 2)
            {
                info[1] = arrName[arrName.Length - 1];
                for (int i = 0; i < arrName.Length - 1; i++)
                {
                    if (i == arrName.Length - 2)
                    {
                        info[0] += arrName[i];
                    }
                    else
                    {
                        info[0] += arrName[i] + ".";
                    }
                }
            }
            else
            {
                info[0] = arrName[0];
            }
            return info;
        }
        private void insertConversation()
        {
            new InsertConversationHandler(this.chatBox.Form.Client).Handle(this.chatBox.Conversation);
        }
    }
}
