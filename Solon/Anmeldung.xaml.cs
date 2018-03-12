﻿using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Solon
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Here we go!");
            Solon.Netzwerk myClass = new Solon.Netzwerk();
            myClass.Netzwerkkonfig();
        }
        /*static void Netzwerk()
        {
            
            var localEndpoint = new IPEndPoint(IPAddress.Loopback, 4040);
            TcpClient client = new TcpClient(localEndpoint);

            client.SendTimeout = 3000;
            client.ReceiveTimeout = 3000;

            var remoteEndpoint = new IPEndPoint(IPAddress.Loopback, 4242);
            client.Connect(remoteEndpoint);


        }*/

        private void b_reg_Click(object sender, RoutedEventArgs e)
        {
            Registrierblatt reg = new Registrierblatt();
            reg.Show();
            this.Close();
        }

        private void b_anmelden_Click(object sender, RoutedEventArgs e)
        {
            AnmeldeBlatt anm = new AnmeldeBlatt();
            anm.Show();
            this.Close();

        }
    }
}
