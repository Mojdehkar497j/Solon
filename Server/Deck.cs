using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Deck
    {
        List<Karte> deck = new List<Karte>(52);
        private List<Karte> mixedDeck;
        public Deck()
        {
            for (int i = 0; i < Enum.GetNames(typeof(Farbe)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Typ)).Length; j++)
                {
                    for (int k = 0; k < Enum.GetNames(typeof(Wert)).Length; k++)
                    {
                        Karte n = new Karte((Farbe)i,(Typ)j,(Wert)k,false);
                        deck.Add(n);
                    }
                }
            }
        }
        
        public void teileInStapel()
        {
            Stapel[] meineStapel = new Stapel[13];
            for (int i = 0; i <= 100; i++)
            {
                deck = Shuffle(deck);
            }

            foreach (Karte k in deck)
            {

                Console.WriteLine(k.Typ + " " + k.Wert + ", ");
            }
        }

        private List<Karte> Shuffle(List<Karte> kartes)
        {
            List<Karte> shuffledKarten = new List<Karte>();

            Random r = new Random();
            while (kartes.Count != 0)
            {
                int rand = r.Next(kartes.Count - 1);
                shuffledKarten.Add(kartes[rand]);
                kartes.RemoveAt(rand);
                
            }

            return shuffledKarten;
        }
    }
}