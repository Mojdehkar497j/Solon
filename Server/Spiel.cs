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
        [DataMember]
        Stapel[] meineStapel = new Stapel[13];
        
        [DataMember]
        public Stapel[] MeineStapel
        {
            get { return meineStapel; }
            set { Stapel[] meineStapel = new Stapel[13];}
        }
    }
}