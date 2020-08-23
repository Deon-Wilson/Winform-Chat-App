using ChatAppServer.SocketServer;
using ReferenceData;
using System.Collections.Generic;
using System.Linq;

namespace ChatAppServer.Handler
{
    public class LoadMoreMessageHandler : BaseThread
    {
        private ServerWorker worker;

        public LoadMoreMessageHandler(ServerWorker worker)
        {
            this.worker = worker;
        }

        public override void Run()
        {
            if (worker.MessageList.Count > worker.From - 1)
            {
                List<ReferenceData.Entity.Message> list = worker.MessageList.Skip(worker.From - 1).Take(15).ToList();
                worker.send(new SocketData("LOADMOREMESSAGE", list));
                worker.From += 15;
            }
        }
    }
}
