namespace _08_03_vozila
{
    // public class Automobil:Vozilo
    public class Automobil : Vozilo
    {
        //private string Naziv;
        //private string Boja;
        //private int KS;
        private int ccm;

        public Automobil(string Naziv, string Boja, int KS, int Ccm):base(Naziv,Boja,KS)
        {
            this.Ccm = Ccm;
        }
        public Automobil(int KS, int Ccm) : this("default naziv","Default boja", KS, Ccm)
        {
        }
        public override string ToString()
        {
            return base.ToString()+" moja kubikaza je:"+this.Ccm;
        }

        public int Ccm { get => ccm; set => ccm = value; }
    }
}