using System;

namespace _01_varijable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracija varijable tipa string
            string ime;

            //Dodjela vrijednosti varijabli => inicijalizacija
            //Operator dodjele vrijednosti => "="
            //Vrijednost sa desne strane se pridodjeljuje 
            //varijabli sa lijeve strane
            ime = "ASP.NET";
            ime = "Mirko Spirko";
            //Izazvalo bi grešku jer je vrijednost grivoga tipa
            //ime = 1;

            //Ispis varijable
            Console.WriteLine(ime);

            //Jedan način spajanja teksta

            Console.Write("Dobro veče, ");
            Console.Write(ime);
            Console.Write("!");

            Console.WriteLine();
            //Drugi način spajanja teksta - konkatenacija
            Console.WriteLine("Dobro veče, {0}!", ime);

            ime = "Mirko";
            string prezime = "Spirko";

            //Kod formatiranja teksta je potrebno paziti na redosljed dodavanja
            //varijabli
            Console.WriteLine("Ime je {1}, a prezime je {0}.", ime, prezime);
            Console.WriteLine("Ime je "+ ime + ", a prezime je "+ prezime + ".");
        }
    }
}
