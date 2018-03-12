using System;
using System.Collections.Generic;
using System.IO;
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
            IPEndPoint localendp = new IPEndPoint(IPAddress.Loopback, 4242);
            TcpListener listener = new TcpListener(localendp);
            listener.Start();
            Console.WriteLine("Server");

            //for (int i = 0; i < 101; i++)
            //{
            while (true)
            {
                TcpClient tcpClient = listener.AcceptTcpClient();

                Task.Run(() =>
                {
                    NetworkStream stream = tcpClient.GetStream();

                    while (true)
                    {
                        using (var reader = new StreamReader(stream, Encoding.ASCII, true, 4096,
                            leaveOpen: true))
                        {
                            string response = reader.ReadLine();
                            Console.WriteLine(response);
                        }

                        using (var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true))
                        {
                            string msg = "abc";
                            writer.WriteLine(msg);
                            //writer.WriteLine(message);
                        }
                    }
                });
            }
        }

        //}


        //Console.ReadKey();
    }
}