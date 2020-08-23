using ChatApp.Views;
using ChatApp.Views.Components;
using System;

namespace ChatApp.Handler
{
    public class OpenConversationHandler
    {
        private delegate void SelectConversationDelegate(ReferenceData.Entity.Conversation cvst);
        private Frame form;
        private Conversation conversation;

        public OpenConversationHandler(Frame form, Conversation cvst)
        {
            this.form = form;
            this.conversation = cvst;
        }
        public void Handle(object sender, EventArgs e)
        {
            form.Invoke(new SelectConversationDelegate(form.SelectConversation), new object[] { conversation.Cvst });
            form.Invoke(new SelectConversationDelegate(form.AddChatBox), new object[] { conversation.Cvst });
        }
    }
}
