using ChatApp.Utils;
using Guna.UI2.WinForms;
using ReferenceData;
using System;

namespace ChatApp.Handler
{
    public class LoadMoreMessageHandler
    {
        private ChatClient client;

        public LoadMoreMessageHandler(ChatClient client)
        {
            this.client = client;
        }
        public void Handle(object sender, EventArgs e)
        {
            Guna2VScrollBar vs = (Guna2VScrollBar)sender;
            if(vs.Value == 0)
            {
                client.send(new SocketData("LOADMOREMESSAGE", null));
            }
        }
    }
}
