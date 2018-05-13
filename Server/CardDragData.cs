using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Solon
{
    internal sealed class CardDragData
    {
        public CardDragData(ObservableCollection<Karte> cards, Karte card)
        {
            Cards = cards;
            Card = card;
        }

        public ObservableCollection<Karte> Cards { get; }
        public Karte Card { get; }
    }
}
