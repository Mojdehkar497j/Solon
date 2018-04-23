using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows;

namespace Solon
{
    class Netzwerk
    {
        public void Netzwerkkonfig()
        {
            /*var localEndpoint = new IPEndPoint(IPAddress.Loopback, 0);
            TcpClient client = new TcpClient(localEndpoint);

            //client.SendTimeout = 3000;
            //client.ReceiveTimeout = 3000;

            var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            client.Connect(remoteEndpoint);
            
            NetworkStream stream = client.GetStream();
            string msg = "abc";
            //Senden(stream);
            */
        }

        /*public void Senden(NetworkStream stream)
        {

            Task.Run(() =>
            {
                var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true);
                
                    writer.WriteLine("abc");
                
            });

            Task.Run(() =>
            {
                var reader = new StreamReader(stream, Encoding.ASCII, true, 4096, leaveOpen: true);
                
                    string response = reader.ReadLine();
                    MessageBox.Show(response);
                
            });
                
            
        }*/

        public void Senden(string name, string password)
        {
            var localEndpoint = new IPEndPoint(IPAddress.Loopback, 0);
            TcpClient client = new TcpClient(localEndpoint);
            var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            client.Connect(remoteEndpoint);
            NetworkStream stream = client.GetStream();


            Task.Run(() =>
            {
                var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true);

                //writer.WriteLine("abc");
                writer.WriteLine(name);
                writer.WriteLine(password);
                writer.Close();

                var reader = new StreamReader(stream, Encoding.ASCII, true, 4096, leaveOpen: true);

                string response = reader.ReadLine();
                reader.Close();
                MessageBox.Show(response);
                
            });


        }
    }
}