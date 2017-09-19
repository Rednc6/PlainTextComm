using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainClient
{
    class Client
    {
        public void Start()
        {
            Car car = new Car("Tesla", "red", "EL23400");

            TcpClient client = new TcpClient("localhost", 10001);
            using (NetworkStream ns = client.GetStream())
            {
                StreamWriter sw = new StreamWriter(ns);

                sw.Write(car);
                sw.Flush();

            }


        }
    }
}
