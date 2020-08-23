using ChatAppServer.SocketServer;
using ReferenceData;
using System;

namespace ChatAppServer.Handler
{
    public class SignOutHandler
    {
        private ServerWorker worker;

        public SignOutHandler(ServerWorker worker)
        {
            this.worker = worker;
        }
        public void Handle(SocketData data)
        {
            ReferenceData.Entity.Account acc = (ReferenceData.Entity.Account)data.Data;
            foreach (var onl in worker.Server.OnlineList)
            {
                if(onl.Acc.id != acc.id)
                {
                    onl.Worker.send(new SocketData("OFFLINE", acc));
                }
            }
            worker.Server.OnlineList.Remove(new OnlineAccount(worker, acc));
            Console.WriteLine($"Account: {acc.firstName} {acc.lastName}, AccountId: {acc.id} Signed Out!!!");
            Console.WriteLine($"Number Of Online Account: {worker.Server.OnlineList.Count}");
        }
    }
}
