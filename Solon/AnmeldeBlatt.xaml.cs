using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Solon
{
    /// <summary>
    /// Interaktionslogik für AnmeldeBlatt.xaml
    /// </summary>
    public partial class AnmeldeBlatt : Window
    {
        public AnmeldeBlatt()
        {
            InitializeComponent();
        }

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anmeldung = new MainWindow();
            anmeldung.Show();
            this.Close();
        }

        private void b_reg_Click(object sender, RoutedEventArgs e)
        {
            string userName = tb_Name.Text;
            string password = tb_passw.Text;
            Netzwerk logIn = new Netzwerk();
            logIn.Senden(userName,password);

            MainWindow spiel = new MainWindow();
            spiel.Show();
            this.Close();



            //    var localEndpoint = new IPEndPoint(IPAddress.Loopback, 0);
            //    TcpClient client = new TcpClient(localEndpoint);

            //    //client.SendTimeout = 3000;
            //    //client.ReceiveTimeout = 3000;

            //    var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            //    client.Connect(remoteEndpoint);

            //    NetworkStream stream = client.GetStream();
            //    Netzwerk login = new Netzwerk();

            //    login.Senden(stream);
        }
    }
}
