using System;
using System.Collections.Generic;
using System.Text;

namespace Prvi
{
    /*
     Ovo je blok komentar
    ovo je druga linija....
     */
    class Automobil
    {
        public string boja="Crvena";
        string MarkaAutomobila;   // zakomentirao jer se ne koristi
        private double KS=45;
        public override string ToString()
        {
            // return base.ToString();
            return "Ja sam Automobil Audi A1, moja boja je "+ this.boja + "\n moja snaga je " 
                + this.KS +" kilovata";

        }

        internal void PostaviSnagu(int v)
        {
            this.KS = v;
        }
    }
}
