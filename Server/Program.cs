using Npgsql;
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

            NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
            "Password=postgres;Database=solon;");
            conn.Open();

            while (true)
            {
                TcpClient tcpClient = listener.AcceptTcpClient();

                Task.Run(() =>
                {
                    NetworkStream stream = tcpClient.GetStream();

                    while (true)
                    {
                        var reader = new StreamReader(stream, Encoding.ASCII, true, 4096, leaveOpen: true);
                        
                            string userName = reader.ReadLine();
                            Console.WriteLine(userName);

                            string password = reader.ReadLine();
                            Console.WriteLine(password);

                            NpgsqlCommand command = new NpgsqlCommand("SELECT 'True' FROM users where password='" +
                            password + "' AND username='" + userName + "'", conn);

                            string angemeldet = (string)command.ExecuteScalar();

                            Console.WriteLine(angemeldet);
                        

                        var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true);
                        
                            string msg = "abc";
                            writer.WriteLine(angemeldet);
                            //writer.WriteLine(message);
                            writer.Close();
                        
                    }
                });
            }
        }

        //}


        //Console.ReadKey();
    }
}