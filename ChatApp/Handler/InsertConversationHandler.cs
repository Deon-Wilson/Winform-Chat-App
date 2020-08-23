using ChatApp.Utils;
using ReferenceData;

namespace ChatApp.Handler
{
    public class InsertConversationHandler
    {
        private ChatClient client;

        public InsertConversationHandler(ChatClient client)
        {
            this.client = client;
        }
        public void Handle(ReferenceData.Entity.Conversation cvst)
        {
            client.send(new SocketData("INSERTCONVERSATION", cvst));
        }
    }
}
