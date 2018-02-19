using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt!");
            var myEndPoint = new IPEndPoint(IPAddress.Any, 4242);
            TcpListener myListener = new TcpListener(myEndPoint);
            myListener.Start();
            while (true)
            {
                ThreadPool.QueueUserWorkItem((listening) =>
                {
                    using (TcpClient myClient = myListener.AcceptTcpClient())
                    {
                        using (NetworkStream myNetworkStream = myClient.GetStream())
                        {
                            //BufferSize: 1024
                            //Encoding: Default

                        }
                    }
                });
            }
        }
    }
}