using System;

namespace Zadaca_16_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Domaca zadaca - 16.12.2020.");
            
            #region DrugiDio
            
            Kolac K1 = new Kolac("Cokoladna ekstaza");
            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Secer", 100);
            K1.DodajSastojak("Cokolada", 300);
            K1.DodajSastojak("Jaje", 50);
            Rerna.Ispeci(ref K1);

            Kolac K2 = new Kolac("Limunska ekstaza");
            K2.DodajSastojak("Margarin", 200);
            K2.DodajSastojak("Secer", 100);
            K2.DodajSastojak("Limun", 300);
            K2.DodajSastojak("Jaje", 50);
            Rerna.Ispeci(ref K2);

            #endregion

            #region Treci dio
            

            Console.WriteLine("\n" + K1);
            Console.WriteLine("Sastojci:\n");
            foreach (var sastojak in K1.Sastojci)
            {
                Console.WriteLine($"Sastojak {sastojak.ImeSastojka} ima gramazu od {sastojak.Gramaza}.");
            }
            Console.WriteLine($"Ukupna tezina ovog kolaca je {(K1.UkupnaGramaza/1000).ToString("F2")} KG.\n");

            #endregion

            #region Cetvrti dio
            try
            {
                K1.DodajSastojak("Limun", 100);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greška:");
                Console.WriteLine(ex.Message + "\n");
            }

            #endregion

            #region Peti Dio
            Console.WriteLine($"Ukupan broj ispecenih kolaca je {Rerna.BrojIspecenihKolaca}.\n");
            #endregion




        }
    }
}
