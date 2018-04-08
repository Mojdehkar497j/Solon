using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solon
{
    class Spieldeck
    {
        string[] deck = new string[52];

        public string[] Deck
        {
            get => deck;
            set => deck = value;
        }

        
    }
}
