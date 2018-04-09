using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class EigenschaftenKarte
    {
        public enum Farbe
        {
            Rot,
            Schwarz
        }

        public enum Typ
        {
            Herz,
            Pik,
            Karo,
            Treff
        }

        public enum Wert
        {
            Ass,
            Koenig,
            Dame,
            Bube,
            Zehn,
            Neun,
            Acht,
            Sieben,
            Sechs,
            Fuenf,
            Vier,
            Drei,
            Zwei
        }

        public bool Verdeckt;
    }
}