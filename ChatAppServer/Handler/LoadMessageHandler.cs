using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;
using ReferenceData.Entity;
using System.Collections.Generic;

namespace ChatAppServer.Handler
{
    public class LoadMessageHandler : BaseThread
    {
        private ServerWorker worker;
        private SocketData data;

        public LoadMessageHandler(ServerWorker worker, SocketData data)
        {
            this.worker = worker;
            this.data = data;
        }

        public override void Run()
        {
            object[] d = (object[])data.Data;
            string conversationId = (string)d[0];
            int offset = (int)d[1];
            int limit = (int)d[2];
            List<Message> list = new MessageDAO().GetMessagesByConversationId(conversationId, offset, limit);
            if (list != null)
            {
                worker.send(new SocketData("MESSAGELIST", list));
                worker.From = limit;
                worker.MessageList = new MessageDAO().GetAllMessagesByConversationId(conversationId);
            }
        }
    }
}
