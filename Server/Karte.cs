using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Solon;

namespace Solon
{
    public class Karte
    {
        private bool verdeckt;
        private Farbe farbe;
        private Typ typ;
        private Wert wert;


        public bool Verdeckt
        {
            get { return verdeckt; }
            set { verdeckt = value; }
        }

        public Farbe Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }
        public Typ Typ
        {
            get { return typ; }
            set { typ = value; }
        }
        public Wert Wert
        {
            get { return wert; }
            set { wert = value; }
        }

        public int Overlap { get; }

        public string ImageSource { get; }

        public Karte(Farbe farbe, Typ typ, Wert wert, bool verdeckt, string cardImage, int overlap)
        {
            Farbe = farbe;
            Typ = typ;
            Wert = wert;
            Verdeckt = verdeckt;
            ImageSource = cardImage;
            Overlap = overlap;
        }

        
    }
}