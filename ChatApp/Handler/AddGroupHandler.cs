using ChatApp.Views;
using System;
using System.Collections.Generic;

namespace ChatApp.Handler
{
    public class AddGroupHandler
    {
        private Frame form;

        public AddGroupHandler(Frame form)
        {
            this.form = form;
        }
        public void Handle(object sender, EventArgs e)
        {
            ReferenceData.Entity.Conversation cvst = new ReferenceData.Entity.Conversation();
            cvst.memberList = new List<ReferenceData.Entity.Account>();
            cvst.memberList.Add(form.User);
            foreach (var mb in form.NewGroup.MemberList)
            {
                cvst.memberList.Add(mb.Acc);
            }
            cvst.title = form.NewGroup.GroupName;
            cvst.title2 = form.NewGroup.GroupName;
            cvst.creatorId = form.User.id;
            cvst.avatar = form.NewGroup.Avatar;
            cvst.avatar2 = form.NewGroup.AvatarName;
            cvst.senderId = form.User.id;
            form.AddChatBox(cvst);
            form.ResetCurrentConversation();
            if (form.NewGroup != null)
            {
                form.NewGroup.Dispose();
                form.NewGroup = null;
            }
        }
    }
}
