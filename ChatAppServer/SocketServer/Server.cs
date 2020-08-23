using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace ChatAppServer.SocketServer
{
    public class Server : BaseThread
    {
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public HashSet<OnlineAccount> OnlineList { get; set; } = new HashSet<OnlineAccount>();
        public Server(string serverName, int serverPort)
        {
            ServerName = serverName;
            ServerPort = serverPort;
        }

        public override void Run()
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ServerName), ServerPort);
                Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(ipep);
                while (true)
                {
                    serverSocket.Listen(100);
                    Console.WriteLine("Waiting connect...");
                    Socket clientSocket = serverSocket.Accept();
                    Console.WriteLine("Accepted connection from: " + clientSocket.RemoteEndPoint.ToString());
                    ServerWorker worker = new ServerWorker(this, clientSocket);
                    worker.IsBackground = true;
                    worker.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
