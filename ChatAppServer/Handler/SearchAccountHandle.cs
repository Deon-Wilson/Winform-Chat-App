using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;
using ReferenceData.Entity;
using System.Collections.Generic;

namespace ChatAppServer.Handler
{
    public class SearchAccountHandle : BaseThread
    {
        private ServerWorker worker;
        private SocketData data;

        public SearchAccountHandle(ServerWorker worker,SocketData data)
        {
            this.worker = worker;
            this.data = data;
        }

        public override void Run()
        {
            string keyword = (string)data.Data;
            List<Account> list = new AccountDAO().SearchAccount(keyword);
            worker.send(new SocketData("SEARCHRESULT", list));
        }
    }
}
