using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Apex.MVVM;
using Apex.Extensions;

namespace Solon
{
    /// <summary>
    /// Interaktionslogik für Spiel.xaml
    /// </summary>
    public partial class Spiel : Window
    {

        public Spiel()
        {
            InitializeComponent();

            //xxx.Source = new BitmapImageSource()

            var myEndPoint = new IPEndPoint(IPAddress.Loopback, 0);
            TcpClient myTcpClient = new TcpClient(myEndPoint);
            myTcpClient.Connect(IPAddress.Loopback,8877);

            using (NetworkStream stream = myTcpClient.GetStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    //writer.Write(var msg = Encoding.ASCII.GetBytes("Deck bitte!"));
                    byte[] msg = Encoding.ASCII.GetBytes("DECK PLS");
                    writer.Write(msg);
                }
                
            }

            

        }
    }
}
