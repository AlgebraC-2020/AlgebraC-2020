using System;

namespace _08_03_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo v1 = new Vozilo(
                Naziv: "vozzz",
                Boja: "Zuta",
                KS: 120);
            Console.WriteLine(v1);

            Automobil a1 = new Automobil(Naziv: "Fiat",
                Boja: "Crveni",
                KS: 200,
                Ccm: 2200);
            Console.WriteLine(a1);

            Brod b1 = new Brod(Naziv: "Marija",
    Boja: "Bijela",
    KS: 35000,
    Istisnina: 5000);
            Console.WriteLine(b1);
        }
    }
}
