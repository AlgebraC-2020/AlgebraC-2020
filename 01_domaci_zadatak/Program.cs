using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        public void ZbrojIRazlika()
        {
            int prvi, drugi;
            try
            {
                Console.WriteLine("Unesite cijeli prvi broj:");
                prvi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesite cijeli drugi broj:");
                drugi = Convert.ToInt32(Console.ReadLine());
                int Zbroj = prvi + drugi;
                Console.WriteLine("Zbroj {0} i {1} je " + Zbroj, prvi, drugi);
                int Razlika = prvi - drugi;
                Console.WriteLine("Razlika {0} i {1} je " + Razlika, prvi, drugi);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Niste unijeli CIJELI broj. Molim vas pokusajte ponovno.");
                ZbrojIRazlika();
            }
        }

        public void UmnozakIKvocijent()
        {
            int prvi, drugi;
            try
            {
                Console.WriteLine("Unesite cijeli prvi broj:");
                prvi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesite cijeli drugi broj:");
                drugi = Convert.ToInt32(Console.ReadLine());
                int Umnozak = prvi * drugi;
                Console.WriteLine("Zbroj {0} i {1} je " + Umnozak, prvi, drugi);
                int Kvocijent = prvi / drugi;
                Console.WriteLine("Razlika {0} i {1} je " + Kvocijent, prvi, drugi);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Niste unijeli CIJELI broj. Molim vas pokusajte ponovno.");
                UmnozakIKvocijent();
            }
        }

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
            int vreliste = 100;
            int lediste = -100;

            Console.WriteLine("Temperatura vrelišta je = {0}.\n" + "Temperatura ledišta je = {1}.", vreliste, lediste);

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            Program rezultat = new Program();
            rezultat.ZbrojIRazlika();

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            rezultat.UmnozakIKvocijent();

        }
    }
}
