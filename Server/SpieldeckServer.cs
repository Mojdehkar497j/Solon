using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class SpieldeckServer
    {
        string[] deck = new string[52];

        public string[] Deck
        {
            get => deck;
            set => deck = value;
        }

        enum Farbe
        {
            Rot,Schwarz
        }

        enum Typ
        {
            Herz,Pik,Karo,Treff
        }

        enum Wert
        {
            Ass,Koenig,Dame,Bube,Zehn,Neun,Acht,Sieben,Sechs,Fuenf,Vier,Drei,Zwei
        }

    }
}
