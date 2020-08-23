using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;

namespace ChatAppServer.Handler
{
    public class UpdateAccountHandler : BaseThread
    {
        private ServerWorker worker;
        private SocketData data;

        public UpdateAccountHandler(ServerWorker worker, SocketData data)
        {
            this.worker = worker;
            this.data = data;
        }

        public override void Run()
        {
            ReferenceData.Entity.Account acc = (ReferenceData.Entity.Account)data.Data;
            ReferenceData.Entity.Account account = new AccountDAO().UpdateAccount(acc);
            worker.send(new SocketData("RESULTUPDATE", account));
        }
    }
}
