using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Server
{
    internal sealed class CardDragData
    {
        public CardDragData(ObservableCollection<Client.Karte> cards, Client.Karte card)
        {
            Cards = cards;
            Card = card;
        }

        public ObservableCollection<Client.Karte> Cards { get; }
        public Client.Karte Card { get; }
    }
}
