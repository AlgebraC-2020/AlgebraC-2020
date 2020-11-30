using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            Console.WriteLine("Temperatura ledišta je 0 stupnjeva.");
            Console.WriteLine("Temperatura vrelišta je 100 stupnjeva");

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            int prvi, drugi, zbroj, razlika;

            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                prvi = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugi = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: ");
                Console.WriteLine(e.Message);
                throw e;
            }

            zbroj = prvi + drugi;
            razlika = prvi - drugi;

            Console.WriteLine($"Zbroj je {zbroj}, a razlika je {razlika}");


            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            int umnozak, kvocijent;

            try
            {
                Console.WriteLine("Unesite prvi broj: ");
                prvi = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                drugi = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: ");
                Console.WriteLine(e.Message);
                throw e;
            }

            umnozak = prvi * drugi;
            kvocijent = prvi / drugi;

            Console.WriteLine($"Umnožak je {umnozak}, a kvocijent je {kvocijent}");

        }
    }
}
