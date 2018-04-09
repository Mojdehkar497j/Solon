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
            Console.WriteLine("Karten werden generiert...");
            
            Spiel myGame = new Spiel();
            
            /*string[] kartenPool = new string[52];
            myKarten.Deck[0] = "hKo";
            myKarten.Deck[1] = "hDa";
            myKarten.Deck[2] = "hBu";
            myKarten.Deck[3] = "hZe";
            myKarten.Deck[4] = "hNe";
            myKarten.Deck[5] = "hAc";
            myKarten.Deck[6] = "hSi";
            myKarten.Deck[7] = "hSe";
            myKarten.Deck[8] = "hFu";
            myKarten.Deck[9] = "hVi";
            myKarten.Deck[10] = "hDr";
            myKarten.Deck[11] = "hZw";
            myKarten.Deck[12] = "hAs";
            myKarten.Deck[13] = "kKo";
            myKarten.Deck[14] = "kDa";
            myKarten.Deck[15] = "kBu";
            myKarten.Deck[16] = "kZe";
            myKarten.Deck[17] = "kNe";
            myKarten.Deck[18] = "kAc";
            myKarten.Deck[19] = "kSi";
            myKarten.Deck[20] = "kSe";
            myKarten.Deck[21] = "kFu";
            myKarten.Deck[22] = "kVi";
            myKarten.Deck[23] = "kDr";
            myKarten.Deck[24] = "kZw";
            myKarten.Deck[25] = "kAs";
            myKarten.Deck[26] = "tKo";
            myKarten.Deck[27] = "tDa";
            myKarten.Deck[28] = "tBu";
            myKarten.Deck[29] = "tZe";
            myKarten.Deck[30] = "tNe";
            myKarten.Deck[31] = "tAc";
            myKarten.Deck[32] = "tSi";
            myKarten.Deck[33] = "tSe";
            myKarten.Deck[34] = "tFu";
            myKarten.Deck[35] = "tVi";
            myKarten.Deck[36] = "tDr";
            myKarten.Deck[37] = "tZw";
            myKarten.Deck[38] = "tAs";
            myKarten.Deck[39] = "pKo";
            myKarten.Deck[40] = "pDa";
            myKarten.Deck[41] = "pBu";
            myKarten.Deck[42] = "pZe";
            myKarten.Deck[43] = "pNe";
            myKarten.Deck[44] = "pAc";
            myKarten.Deck[45] = "pSi";
            myKarten.Deck[46] = "pSe";
            myKarten.Deck[47] = "pFu";
            myKarten.Deck[48] = "pVi";
            myKarten.Deck[49] = "pDr";
            myKarten.Deck[50] = "pZw";
            myKarten.Deck[51] = "pAs";*/


            IPEndPoint localendp = new IPEndPoint(IPAddress.Loopback, 8877);
            TcpListener listener = new TcpListener(localendp);
            listener.Start();
            Console.WriteLine("Server ist eingeschalten!");

            using (TcpClient tcpClient = listener.AcceptTcpClient())
            {
                using (NetworkStream stream = tcpClient.GetStream())
                {
                    
                    while (true)
                    {
                        using (var reader = new StreamReader(stream, Encoding.ASCII, true, 4096, leaveOpen: true))
                        {
                            string response = reader.ReadLine();
                            Console.WriteLine(response);
                        }

                        using (var writer = new StreamWriter(stream, Encoding.ASCII, 4096, leaveOpen: true))
                        {
                            string message = Convert.ToString(writer.GetHashCode());
                            writer.WriteLine(message);

                        }
                    }
                }
            }

            //Console.ReadKey();
        
        }
    }
}