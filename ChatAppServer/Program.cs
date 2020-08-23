using ChatAppServer.SocketServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string serverName = "127.0.0.1";
            int serverPort = 6868;
            Server server = new Server(serverName, serverPort);
            server.Start();
        }
    }
}
