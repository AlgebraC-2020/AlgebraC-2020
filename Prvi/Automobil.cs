using System;
using System.Collections.Generic;
using System.Text;

namespace Prvi
{
    class Automobil
    {
        public string boja="Crvena";
        string MarkaAutomobila;
        double KS;
        public override string ToString()
        {
            // return base.ToString();
            return "Ja sam Automobil Audi A1, moja boja je "+this.boja;


        }
    }
}
