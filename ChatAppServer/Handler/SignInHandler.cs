using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;
using System;
using System.Collections.Generic;

namespace ChatAppServer.Handler
{
    public class SignInHandler : BaseThread
    {
        private ServerWorker worker;
        private SocketData data;

        public SignInHandler(ServerWorker worker, SocketData data)
        {
            this.worker = worker;
            this.data = data;
        }

        public override void Run()
        {
            ReferenceData.Entity.Account acc = (ReferenceData.Entity.Account)data.Data;
            ReferenceData.Entity.Account user = new AccountDAO().GetAccountBySignInInfo(acc.email, acc.password);
            SocketData response = new SocketData("ACCOUNT", user);
            worker.send(response);
            if (user != null)
            {
                worker.Server.OnlineList.Add(new OnlineAccount(worker, user));
                sendConversationList(user);
                Console.WriteLine($"Account: {user.firstName} {user.lastName}, AccountId: {user.id} Signed In!!!");
                Console.WriteLine($"Number Of Online Account: {worker.Server.OnlineList.Count}");
            }
        }

        private void sendConversationList(ReferenceData.Entity.Account user)
        {
            List<ReferenceData.Entity.Conversation> list = new ConversationDAO(worker.Server.OnlineList).GetConversationListOfAccount(user.id);
            if (list != null)
            {
                SocketData response = new SocketData("CONVERSATIONLIST", list);
                worker.send(response);
                foreach (var onl in worker.Server.OnlineList)
                {
                    if (onl.Acc.id != user.id)
                    {
                        foreach (var c in list)
                        {
                            if (c.memberList.Count == 2)
                            {
                                onl.Worker.send(new SocketData("ONLINE", user));
                            }
                        }
                    }
                }
            }
        }

    }
}
