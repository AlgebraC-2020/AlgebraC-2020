using System;
using System.Collections.Generic;
using System.Text;

namespace Zadaca_16_12
{
    static class Rerna
    {
        public static int BrojIspecenihKolaca;

        public static void Ispeci(ref Kolac K1)
        {
            if (K1.ImeKolaca != null && K1.Sastojci.Count > 0)
            {
                BrojIspecenihKolaca++;
                K1.Ispecen = true;
            }
            else
            {
                K1.Ispecen = false;
            }
           
        }
    }
}
