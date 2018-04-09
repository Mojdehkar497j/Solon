using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Spiel
    {
        //1 spiel = 13 stapel 

        Stapel[] meineStapel = new Stapel[13];
        

        public Stapel[] MeineStapel
        {
            get { return MeineStapel; }
            set { Stapel[] meineStapel = new Stapel[13];}
        }
    }
}