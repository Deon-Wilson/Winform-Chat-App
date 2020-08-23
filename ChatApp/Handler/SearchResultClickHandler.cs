using ChatApp.Views;
using ReferenceData.Entity;
using System;
using System.Collections.Generic;

namespace ChatApp.Handler
{
    public class SearchResultClickHandler
    {
        private Frame form;
        private Account account;

        public SearchResultClickHandler(Frame form, Account acc)
        {
            this.form = form;
            this.account = acc;
        }
        public void Handle(object sender, EventArgs e)
        {
            if(form.NewChat != null)
            {
                form.NewChat.Dispose();
                form.NewChat = null;
            }
            int b = 0;
            foreach(var c in form.ConversationList)
            {
                if(c.Cvst.memberList.Count == 2)
                {
                    if(account.id == c.Cvst.memberList[0].id || account.id == c.Cvst.memberList[1].id)
                    {
                        form.DisplayConversations();
                        form.SelectConversation(c.Cvst);
                        form.AddChatBox(c.Cvst);
                        b = 1;
                        break;
                    }
                }
            }
            if(b==0)
            {
                Conversation cvst = new Conversation();
                cvst.memberList = new List<Account>();
                cvst.memberList.Add(account);
                cvst.memberList.Add(form.User);
                cvst.title = account.firstName + " " + account.lastName;
                cvst.creatorId = form.User.id;
                cvst.avatar = account.avatar;
                cvst.senderId = form.User.id;
                form.AddChatBox(cvst);
                form.ResetCurrentConversation();
                form.DisplayConversations();
            }
        }
        public void Handle2(object sender, EventArgs e)
        {
            if (form.NewChat != null)
            {
                form.NewChat.Dispose();
                form.NewChat = null;
            }
            int b = 0;
            foreach (var c in form.ConversationList)
            {
                if (c.Cvst.memberList.Count == 2)
                {
                    if (account.id == c.Cvst.memberList[0].id || account.id == c.Cvst.memberList[1].id)
                    {
                        form.SelectConversation(c.Cvst);
                        form.AddChatBox(c.Cvst);
                        b = 1;
                        break;
                    }
                }
            }
            if (b == 0)
            {
                Conversation cvst = new Conversation();
                cvst.memberList = new List<Account>();
                cvst.memberList.Add(account);
                cvst.memberList.Add(form.User);
                cvst.title = account.firstName + " " + account.lastName;
                cvst.creatorId = form.User.id;
                cvst.avatar = account.avatar;
                cvst.senderId = form.User.id;
                form.AddChatBox(cvst);
                form.ResetCurrentConversation();
            }
        }
    }
}
