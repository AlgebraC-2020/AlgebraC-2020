using System;

namespace _05_03_svi_djeljitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj, vracam djeljitelje:");
            int nekibroj = 0;
            try
            {
                nekibroj = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("nije broj" + e.Message);
            }

            int brojacDjeljitelja = 0;
            for (int i = nekibroj; i >= 1; i--)
            {
                if (nekibroj % i == 0)
                {
                    brojacDjeljitelja++;
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine("\nUkupno ima {0} djeljitelja", brojacDjeljitelja);
        }
    }
}
