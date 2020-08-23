

namespace ChatAppServer.SocketServer
{
    public class OnlineAccount
    {
        public ServerWorker Worker { get; set; }
        public ReferenceData.Entity.Account Acc { get; set; }
        public OnlineAccount(ServerWorker worker, ReferenceData.Entity.Account acc)
        {
            Worker = worker;
            Acc = acc;
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType() != typeof(OnlineAccount))
            {
                return false;
            }
            OnlineAccount other = (OnlineAccount)obj;
            if(Acc.id != other.Acc.id)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return Acc.id;
        }
    }
}
