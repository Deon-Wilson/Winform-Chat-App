using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;
using System.Collections.Generic;
namespace ChatAppServer.Handler
{
    public class MessageHandler : BaseThread
    {
        private SocketData data;
        private ServerWorker worker;
        private MessageDAO messageDAO;

        public MessageHandler(ServerWorker worker,SocketData data)
        {
            this.data = data;
            this.worker = worker;
            this.messageDAO = new MessageDAO();
        }
        public override void Run()
        {
            List<ReferenceData.Entity.Message> mList = (List<ReferenceData.Entity.Message>)data.Data;
            foreach (var message in mList)
            {
                messageDAO.InsertMessage(message);
                foreach (var onl in worker.Server.OnlineList)
                {
                    foreach (var u in message.Conversation.memberList)
                    {
                        if (u.id == onl.Acc.id && u.id != message.senderId)
                        {
                            onl.Worker.send(new SocketData("MESSAGE", message));
                        }
                    }
                }
            }
        }
    }
}
