using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [DataContract]
    class Spiel
    {
        //1 spiel = 13 stapel 
        Stapel[] meineStapel = new Stapel[13];

        

        public Stapel[] MeineStapel
        {
            get { return meineStapel; }
            set { meineStapel = value; }
        }
        
        
    }
}
    
