using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [DataContract]
    class Spiel
    {
        //1 spiel = 13 stapel 

        Deck[] meineStapel = new Deck[13];

        public Deck[] MeineStapel
        {
            get { return meineStapel; }
            set { meineStapel = value; }
        }

        
    }
}