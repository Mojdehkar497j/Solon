using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Solon
{
    class Netzwerk
    {
        static void Netzwerkkonfig()
        {
            var localEndpoint = new IPEndPoint(IPAddress.Loopback, 4040);
            TcpClient client = new TcpClient(localEndpoint);

            client.SendTimeout = 3000;
            client.ReceiveTimeout = 3000;

            var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            client.Connect(remoteEndpoint);
        }
    }
}
