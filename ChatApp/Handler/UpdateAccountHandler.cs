using ChatApp.Utils;
using ReferenceData;
using ReferenceData.Entity;

namespace ChatApp.Handler
{
    public class UpdateAccountHandler
    {
        private ChatClient client;

        public UpdateAccountHandler(ChatClient client)
        {
            this.client = client;
        }
        public void Handle(Account acc)
        {
            client.send(new SocketData("UPDATEACCOUNT", acc));
        }
    }
}
