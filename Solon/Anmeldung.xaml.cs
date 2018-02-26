using System;
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
            Console.WriteLine("Here we go!");

            Solon.Netzwerk myClass = new Solon.Netzwerk();
            myClass.Netzwerkkonfig();
        }
        

        private void b_reg_Click(object sender, RoutedEventArgs e)
        {
            Registrierblatt reg = new Registrierblatt();
            reg.Show();
            this.Close();
        }
    }
}
