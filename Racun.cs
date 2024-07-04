using System;

namespace HelloWorld
{
    [Serializable]
    public class Racun
    {
        public int Sifra { get; set; }

        public string Naziv { get; set; }

        public double Stanje { get; set; }

        public void Uplata(double iznos)
        {
            if (iznos > 0)
            {
                Stanje += iznos;
            }
        }
    }
}
