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
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Markup;
using System.Globalization;

namespace Solon
{
    /// <summary>
    /// Interaktionslogik für Spiel.xaml
    /// </summary>
    public partial class Spiel : Window
    {
        private readonly ObservableCollection<Karte> Ablage = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> AblageSichtbar = new ObservableCollection<Karte>();

        private readonly ObservableCollection<Karte> Fertig1 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Fertig2 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Fertig3 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Fertig4 = new ObservableCollection<Karte>();

        private readonly ObservableCollection<Karte> Stapel1 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel2 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel3 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel4 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel5 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel6 = new ObservableCollection<Karte>();
        private readonly ObservableCollection<Karte> Stapel7 = new ObservableCollection<Karte>();

        public Spiel()
        {
            InitializeComponent();
            
            
            //Stapel1.Add(new Karte(Farbe.Schwarz,Typ.Treff, Wert.Koenig, false, "images\\KC.png", overlap: 0));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Dame, false, "images\\QC.png", overlap: 30));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Bube, false,"images\\JC.png", overlap: 60));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Zehn, false,"images\\10C.png", overlap: 90));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Neun, false, "images\\9C.png", overlap: 120));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Acht, false, "images\\8C.png", overlap: 150));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Sieben, false,  "images\\7C.png", overlap: 180));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Sechs, false,  "images\\6C.png", overlap: 210));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Fuenf, false, "images\\5C.png", overlap: 240));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Vier, false, "images\\4C.png", overlap: 270));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Drei, false, "images\\3C.png", overlap: 300));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Zwei, false, "images\\2C.png", overlap: 330));
            //Stapel1.Add(new Karte(Farbe.Schwarz, Typ.Treff, Wert.Ass, false, "images\\AC.png", overlap: 360));
            //lb_Stapel1.ItemsSource = Stapel1;

            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Koenig, false, "images\\KD.png", overlap: 0));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Dame, false,  "images\\QD.png", overlap: 30));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Bube, false, "images\\JD.png", overlap: 60));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Zehn, false, "images\\10D.png", overlap: 90));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Neun, false, "images\\9D.png", overlap: 120));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Acht, false, "images\\8D.png", overlap: 150));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Sieben, false, "images\\7D.png", overlap: 180));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Sechs, false, "images\\6D.png", overlap: 210));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Fuenf, false, "images\\5D.png", overlap: 240));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Vier, false, "images\\4D.png", overlap: 270));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Drei, false, "images\\3D.png", overlap: 300));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Zwei, false, "images\\2D.png", overlap: 330));
            //Stapel2.Add(new Karte(Farbe.Rot, Typ.Karo, Wert.Ass, false, "images\\AD.png", overlap: 360));
            //lb_Stapel2.ItemsSource = Stapel2;

            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Koenig, false,  "images\\KH.png", overlap: 0));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Dame, false, "images\\QH.png", overlap: 30));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Bube, false, "images\\JH.png", overlap: 60));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Zehn, false,  "images\\10H.png", overlap: 90));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Neun, false, "images\\9H.png", overlap: 120));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Acht, false, "images\\8H.png", overlap: 150));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Sieben, false, "images\\7H.png", overlap: 180));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Sechs, false, "images\\6H.png", overlap: 210));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Fuenf, false, "images\\5H.png", overlap: 240));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Vier, false, "images\\4H.png", overlap: 270));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Drei, false, "images\\3H.png", overlap: 300));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Zwei, false, "images\\2H.png", overlap: 330));
            //Stapel3.Add(new Karte(Farbe.Rot, Typ.Herz, Wert.Ass, false, "images\\AH.png", overlap: 360));
            //lb_Stapel3.ItemsSource = Stapel3;

            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Koenig, false, "images\\KS.png", overlap: 0));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Dame, false,  "images\\QS.png", overlap: 30));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Bube, false, "images\\JS.png", overlap: 60));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Zehn, false, "images\\10S.png", overlap: 90));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Neun, false, "images\\9S.png", overlap: 120));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Acht, false, "images\\8S.png", overlap: 150));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Sieben, false, "images\\7S.png", overlap: 180));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Sechs, false, "images\\6S.png", overlap: 240));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Fuenf, false, "images\\5S.png", overlap: 270));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Vier, false, "images\\4S.png", overlap: 300));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Drei, false, "images\\3S.png", overlap: 330));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Zwei, false, "images\\2S.png", overlap: 360));
            //Stapel4.Add(new Karte(Farbe.Schwarz, Typ.Pik, Wert.Ass, false, "images\\AS.png", overlap: 360));
            //lb_Stapel4.ItemsSource = Stapel4;
        }

        private void Image_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Image img = (Image)sender;
                Karte card = (Karte)img.DataContext;

                ItemsControl parent = FindAncestor<ItemsControl>(img);
                var itemsSource = GetItemsSource(parent);

                // Initialize the drag & drop operation
                var dragData = new CardDragData(itemsSource, card);
                DataObject dataObject = new DataObject("data", dragData);
                DragDrop.DoDragDrop(img, dataObject, DragDropEffects.Move);
            }
        }

        private void column_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("data"))
            {
                CardDragData data = e.Data.GetData("data") as CardDragData;
                ObservableCollection<Karte> sourceCards = data.Cards;
                ObservableCollection<Karte> targetCards = GetItemsSource(sender);
                Karte movedCard = data.Card;

                sourceCards.Remove(movedCard);
                targetCards.Add(movedCard);
            }
        }

        // Helper to search up the VisualTree
        private static T FindAncestor<T>(DependencyObject current)
            where T : DependencyObject
        {
            do
            {
                if (current is T)
                    return (T)current;

                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private static ObservableCollection<Karte> GetItemsSource(object o)
        {
            ItemsControl control = o as ItemsControl;
            var source = (ObservableCollection<Karte>)control.ItemsSource;
            return source;
        }

    }
    public class OverlapConverter : MarkupExtension, IValueConverter
    {
        #region OverlapConverter Members
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int overlap = (int)value;
            return new Thickness(0, -overlap, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
