using System;

namespace _14_inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pointovi i interfacei");

            Point p1 = new Point(3,5) ;

            Console.WriteLine("Point "+p1);

            p1.PrintPoint();

            p1.Mojaboja=p1.setBoja("Zelena");

            p1.PrintPoint();

            p1.Mojaboja = p1.setBoja("Black");

            p1.PrintPoint();

            p1.PomakniMeZaX(7);
            p1.PomakniMeZaY(5);

            p1.PrintPoint();


            Korisnik k1 = new Korisnik();
            k1.RegistrirajMe("admin");
            Console.WriteLine("moje korisnicko ime je "+k1);

        }
    }
}
