using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPClient_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5566));

            byte[] data = new byte[1024];
            int count = clientSocket.Receive(data);
            string msg = Encoding.UTF8.GetString(data, 0, count);

            while (true)
            {
                string s = Console.ReadLine();
                clientSocket.Send(Message.GetBytes(s));
                
            }
            
        }
    }
}
