﻿using System;
using System.Collections.Generic;
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
    }
}
