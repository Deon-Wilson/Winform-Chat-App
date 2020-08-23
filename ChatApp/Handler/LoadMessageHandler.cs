using ChatApp.Utils;
using ReferenceData;

namespace ChatApp.Handler
{
    public class LoadMessageHandler
    {
        private ChatClient client;

        public LoadMessageHandler(ChatClient client)
        {
            this.client = client;
        }
        public void Handle(string conversationId, int offset, int limit)
        {
            object[] loadMessage = new object[] { conversationId, offset, limit };
            client.send(new SocketData("LOADMESSAGE", loadMessage));
            
        }
    }
}
