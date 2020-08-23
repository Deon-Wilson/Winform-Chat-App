using ChatApp.Utils;
using ReferenceData;
using ReferenceData.Entity;
using System.Collections.Generic;

namespace ChatApp.Handler
{
    public class InsertMessageHandler
    {
        private ChatClient client;

        public InsertMessageHandler(ChatClient client)
        {
            this.client = client;
        }
        public void Handle(List<Message> mList)
        {
            client.send(new SocketData("INSERTMESSAGE", mList));
        }
    }
}
