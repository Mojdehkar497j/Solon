using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Solon
{
    class Netzwerk
    {
        public void Netzwerkkonfig()
        {
            var localEndpoint = new IPEndPoint(IPAddress.Loopback, 0);
            TcpClient client = new TcpClient(localEndpoint);

            client.SendTimeout = 0;
            client.ReceiveTimeout = 0;

            var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            client.Connect(remoteEndpoint);

            using (NetworkStream stream = client.GetStream())
            {
                while (true)
                {
                    using (var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true))
                    {
                        writer.WriteLine("Hello World!");
                    }

                    using (var reader = new StreamReader(stream, Encoding.ASCII, true, 4096, leaveOpen: true))
                    {
                        string response = reader.ReadLine();
                        Console.WriteLine(response);
                    }
                }
            }
        }
    }
}
