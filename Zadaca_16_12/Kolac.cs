using System;
using System.Collections.Generic;

namespace Zadaca_16_12
{
    internal class Kolac
    {
        public string ImeKolaca { get; set; }
        public bool Ispecen { get; set; }
        public double UkupnaGramaza { get; set; }
        public List<Sastojak> Sastojci = new List<Sastojak>();

        public Kolac(string imeKolaca)
        {
            this.ImeKolaca = imeKolaca;
            
        }

        internal void DodajSastojak(string imeSastojka, int gramaza)
        {
            if (Ispecen)
            {
                throw new Exception("Ne mozete dodavati sastojke, kolac je vec ispecen.");
            }
            else
            {
                Sastojci.Add(new Sastojak() { ImeSastojka = imeSastojka, Gramaza = gramaza });
                UkupnaGramaza += gramaza;
            }
            
        }

        internal class Sastojak
        {
            public string ImeSastojka { get; set; }
            public int Gramaza { get; set; }
        }

        public override string ToString()
        {
            if (Ispecen)
            {
                return "Kolac je pecen.";
            }
            else
            {
                return "Kolac nije pecen.";
            }
        }


    }
}