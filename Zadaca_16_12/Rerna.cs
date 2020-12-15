using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca_16_12
{
    static class Rerna
    {
        public static int BrojIspecenihKolaca;

        public static void Ispeci(ref Kolac kolac)
        {
            if (kolac.ImeKolaca != null && kolac.Sastojci.Count > 0)
            {
                BrojIspecenihKolaca++;
                kolac.Ispecen = true;
            }
            else
            {
                kolac.Ispecen = false;
            }
           
        }
    }
}
