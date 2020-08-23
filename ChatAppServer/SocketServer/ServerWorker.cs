using System;
using System.Collections.Generic;
using System.Net.Sockets;
using ChatAppServer.Handler;
using ReferenceData;
using ReferenceData.Utils;

namespace ChatAppServer.SocketServer
{
    public class ServerWorker : BaseThread
    {
        public int From = 0;
        public List<ReferenceData.Entity.Message> MessageList = new List<ReferenceData.Entity.Message>();
        public Socket ClientSocket { get; set; }
        public Server Server { get; set; }
        public ServerWorker(Server server, Socket clientSocket)
        {
            Server = server;
            ClientSocket = clientSocket;
        }
        public override void Run()
        {
            try
            {
                handleClientSocket();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ClientSocket.Close();
            }
        }

        private void handleClientSocket()
        {
            while (true)
            {
                SocketData data = receive();
                string dataType = data.DataType.ToUpper();
                Console.WriteLine("Data type is: " + dataType);
                if (dataType.Equals("CLOSE"))
                {
                    break;
                }
                else if (dataType.Equals("SIGNOUT"))
                {
                    new SignOutHandler(this).Handle(data);
                    break;
                }
                else
                {
                    switch (dataType)
                    {
                        case "SIGNUP":
                            try
                            {
                                new SignUpHandler(this, data).Start();
                            }catch(Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "SIGNIN":
                            try
                            {
                                new SignInHandler(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "LOADMESSAGE":
                            try
                            {
                                new LoadMessageHandler(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "SEARCHACCOUNT":
                            try
                            {
                                new SearchAccountHandle(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "INSERTCONVERSATION":
                            try
                            {
                                new InsertConversationHandler(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "INSERTMESSAGE":
                            try
                            {
                                new MessageHandler(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "LOADMOREMESSAGE":
                            try
                            {
                                new LoadMoreMessageHandler(this).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "UPDATEACCOUNT":
                            try
                            {
                                new UpdateAccountHandler(this, data).Start();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                        case "NULLDATA":
                            Console.WriteLine("Data is null");
                            break;
                    }
                }
            }
            ClientSocket.Close();
        }
        public void send(object obj)
        {
            try
            {
                ClientSocket.Send(ChatAppUtils.Serialize(obj));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ClientSocket.Close();
            }
        }
        public SocketData receive()
        {
            byte[] data = new byte[79000000];
            try
            {
                ClientSocket.Receive(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ClientSocket.Close();
            }
            SocketData d = (SocketData)ChatAppUtils.Deserialize(data);
            if (d == null)
            {
                return new SocketData("NULLDATA", null);
            }
            return d;
        }

    }
}
