using ChatApp.Handler;
using ReferenceData;
using ReferenceData.Entity;
using ReferenceData.Utils;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatApp.Utils
{

    public class ChatClient
    {
        public string ServerName { get; set; }
        public int ServerPort { get; set; }
        public Socket Socket { get; set; }
        public bool IsConnected { get; set; }
        public ChatClient(string serverName, int serverPort)
        {
            ServerName = serverName;
            ServerPort = serverPort;
        }

        public void Connect()
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ServerName), ServerPort);
                Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Socket.Connect(ipep);
                IsConnected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                IsConnected = false;
            }
        }

        public void Close()
        {
            if(IsConnected)
            {
                send(new SocketData("CLOSE", null));
                this.Socket.Close();
                IsConnected = false;
            }
        }
        public bool SignUp(SocketData data)
        {
            if (data.DataType.ToUpper().Equals("SIGNUP"))
            {
                send(data);
                SocketData response = receive();
                if ((bool)response.Data)
                {
                    return true;
                }
            }
            return false;
        }
        public Account SignIn(SocketData data)
        {
            if (data.DataType.ToUpper().Equals("SIGNIN"))
            {
                send(data);
                SocketData response = receive();
                return (Account)response.Data;
            }
            return null;
        }

        public void SignOut(Account acc)
        {
            if(IsConnected)
            {
                SocketData data = new SocketData("SIGNOUT", acc);
                send(data);
                this.Socket.Close();
                IsConnected = false;
            }
        }

        public void startReadResponse(ReadResponseHandler handler)
        {
            Thread t = new Thread(() =>
            {
                handler.readResponseLoop();
            });
            t.IsBackground = true;
            t.Start();
        }
        public void send(object obj)
        {
            if(IsConnected)
            {
                try
                {
                    Socket.Send(ChatAppUtils.Serialize(obj));
                } catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public SocketData receive()
        {
            byte[] data = new byte[79000000];
            if (IsConnected)
            {
                try
                {
                    Socket.Receive(data);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return (SocketData)ChatAppUtils.Deserialize(data);
        }
    }
}
