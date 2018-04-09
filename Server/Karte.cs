using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Karte:EigenschaftenKarte
    {
        public object myKarte { get; set; }
        public Karte(object Farbe, object Typ, object Wert, bool Verdeckt)
        {
            
        }
    }
}
