using System;
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

namespace Client
{
    /// <summary>
    /// Interaktionslogik für Registrierblatt.xaml
    /// </summary>
    public partial class Registrierblatt : Window
    {
        public Registrierblatt()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow anm = new MainWindow();
            anm.Show();
            this.Close();
        }

        private void b_reg_Click(object sender, RoutedEventArgs e)
        {
            Spiel spiel = new Spiel();
            spiel.Show();
            this.Close();
        }

        void TextBox_un_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = string.Empty;
            box.Foreground = Brushes.Black;
            box.GotFocus -= TextBox_un_GotFocus;
        }

        void TextBox_un_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text.Trim().Equals(string.Empty))
            {
                box.Text = "Username:";
                box.Foreground = Brushes.Black;
                box.GotFocus += TextBox_un_GotFocus;
            }
        }

        void TextBox_pw_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = string.Empty;
            box.Foreground = Brushes.Black;
            box.GotFocus -= TextBox_un_GotFocus;
        }

        void TextBox_pw_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text.Trim().Equals(string.Empty))
            {
                box.Text = "Passwort:";
                box.Foreground = Brushes.Black;
                box.GotFocus += TextBox_un_GotFocus;
            }
        }
    }
}
