using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Stapel
    {
        public List<Karte> Deck{ get; private set; }   
        public Stapel()
        {
            Deck = new List<Karte>();
            for (int count=0; count<=52; count++)
            {
                //Deck[count] = 
            }
        }
        
        

    }
}
