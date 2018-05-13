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
            
            Stapel1.Add(new Karte("images\\KC.png", overlap: 0));
            Stapel1.Add(new Karte("images\\QC.png", overlap: 30));
            Stapel1.Add(new Karte("images\\JC.png", overlap: 60));
            Stapel1.Add(new Karte("images\\10C.png", overlap: 90));
            Stapel1.Add(new Karte("images\\9C.png", overlap: 120));
            Stapel1.Add(new Karte("images\\8C.png", overlap: 150));
            Stapel1.Add(new Karte("images\\7C.png", overlap: 180));
            Stapel1.Add(new Karte("images\\6C.png", overlap: 210));
            Stapel1.Add(new Karte("images\\5C.png", overlap: 240));
            Stapel1.Add(new Karte("images\\4C.png", overlap: 270));
            Stapel1.Add(new Karte("images\\3C.png", overlap: 300));
            Stapel1.Add(new Karte("images\\2C.png", overlap: 330));
            Stapel1.Add(new Karte("images\\AC.png", overlap: 360));
            lb_Stapel1.ItemsSource = Stapel1;

            Stapel2.Add(new Karte("images\\KD.png", overlap: 0));
            Stapel2.Add(new Karte("images\\QD.png", overlap: 30));
            Stapel2.Add(new Karte("images\\JD.png", overlap: 60));
            Stapel2.Add(new Karte("images\\10D.png", overlap: 90));
            Stapel2.Add(new Karte("images\\9D.png", overlap: 120));
            Stapel2.Add(new Karte("images\\8D.png", overlap: 150));
            Stapel2.Add(new Karte("images\\7D.png", overlap: 180));
            Stapel2.Add(new Karte("images\\6D.png", overlap: 210));
            Stapel2.Add(new Karte("images\\5D.png", overlap: 240));
            Stapel2.Add(new Karte("images\\4D.png", overlap: 270));
            Stapel2.Add(new Karte("images\\3D.png", overlap: 300));
            Stapel2.Add(new Karte("images\\2D.png", overlap: 330));
            Stapel2.Add(new Karte("images\\AD.png", overlap: 360));
            lb_Stapel2.ItemsSource = Stapel2;

            Stapel3.Add(new Karte("images\\KH.png", overlap: 0));
            Stapel3.Add(new Karte("images\\QH.png", overlap: 30));
            Stapel3.Add(new Karte("images\\JH.png", overlap: 60));
            Stapel3.Add(new Karte("images\\10H.png", overlap: 90));
            Stapel3.Add(new Karte("images\\9H.png", overlap: 120));
            Stapel3.Add(new Karte("images\\8H.png", overlap: 150));
            Stapel3.Add(new Karte("images\\7H.png", overlap: 180));
            Stapel3.Add(new Karte("images\\6H.png", overlap: 210));
            Stapel3.Add(new Karte("images\\5H.png", overlap: 240));
            Stapel3.Add(new Karte("images\\4H.png", overlap: 270));
            Stapel3.Add(new Karte("images\\3H.png", overlap: 300));
            Stapel3.Add(new Karte("images\\2H.png", overlap: 330));
            Stapel3.Add(new Karte("images\\AH.png", overlap: 360));
            lb_Stapel3.ItemsSource = Stapel3;

            Stapel4.Add(new Karte("images\\KS.png", overlap: 0));
            Stapel4.Add(new Karte("images\\QS.png", overlap: 30));
            Stapel4.Add(new Karte("images\\JS.png", overlap: 60));
            Stapel4.Add(new Karte("images\\10S.png", overlap: 90));
            Stapel4.Add(new Karte("images\\9S.png", overlap: 120));
            Stapel4.Add(new Karte("images\\8S.png", overlap: 150));
            Stapel4.Add(new Karte("images\\7S.png", overlap: 180));
            Stapel4.Add(new Karte("images\\6S.png", overlap: 240));
            Stapel4.Add(new Karte("images\\4S.png", overlap: 270));
            Stapel4.Add(new Karte("images\\3S.png", overlap: 300));
            Stapel4.Add(new Karte("images\\2S.png", overlap: 330));
            Stapel4.Add(new Karte("images\\AS.png", overlap: 360));
            lb_Stapel4.ItemsSource = Stapel4;
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
                Karte movedCard = data.Karte;

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
}
