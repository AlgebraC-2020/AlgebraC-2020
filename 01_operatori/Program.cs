using System;

namespace _01_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unos podataka
            int prviBroj;
            Console.WriteLine("Unesite prvi broj: ");
            prviBroj = int.Parse(Console.ReadLine());

            int drugiBroj;
            Console.WriteLine("Unesite drugi broj: ");
            drugiBroj = int.Parse(Console.ReadLine());

            //Izračun - obrada podataka
            int zbroj;
            zbroj = prviBroj + drugiBroj;
            //Deklaracija i inicijalizacija u istom redu.
            int razlika = prviBroj - drugiBroj;
            int umnozak = prviBroj * drugiBroj;
            //pretvorba decimalnog broja u int, uvijek odreže 
            //sva decimalna mjesta. NEMA ZAOKRUŽIVANJA!!
            //int kvocijent = prviBroj / drugiBroj;
            double kvocijent = (double)prviBroj / (double)drugiBroj;

            Console.WriteLine("Zbroj je {0}.", zbroj);
            Console.WriteLine("{0} - {1} = {2}", prviBroj,
                drugiBroj, razlika);
            Console.WriteLine("Umnožak je " + umnozak + ".");
            Console.WriteLine("Kvocijent je {0}.", kvocijent);

            Console.WriteLine("Pritisnite bilo koju tipku za kraj.");
        }
    }
}
