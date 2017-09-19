using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainTextComm
{
    class Server
    {
        private string _clientLine;
        private string _serverLine;
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();

            TcpClient socket = server.AcceptTcpClient();
            using (NetworkStream ns = socket.GetStream())
            {
                StreamReader sr = new StreamReader(ns);

                _clientLine = sr.ReadLine();
                Console.Write("From Client | " + _clientLine);

            }

        }
    }
}
