using System;

namespace _14_inter
{
    internal class Point : IPoint
    {
        private BojaTocke mojaboja = BojaTocke.Plava;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        private int x;
        private int y;

        public int X { get => this.x; set => x = value; }
        public int Y { get => this.y; set => y = value; }
        internal BojaTocke Mojaboja { get => mojaboja; set => mojaboja = value; }

        public void PomakniMeZaX(int v)
        {
            this.X += v;
        }

        public override string ToString()
        {
            return string.Format("( coord {0},{1}, moja boja je: {2})", X, Y, Mojaboja);
        }

        public void PrintPoint()
        {
            Console.WriteLine("Point " + this);
        }

        public BojaTocke setBoja(string boja)
        {
            if (boja.ToLower() == "zelena" || boja.ToLower() == "green")
            {
                return BojaTocke.Zelena;
            }
            else
            {
                return BojaTocke.Crvena;
            }
        }

        public void PomakniMeZaY(int v)
        {
            this.Y += v;
        }
    }
}