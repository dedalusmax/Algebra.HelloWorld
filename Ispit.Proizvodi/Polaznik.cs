using System;

namespace Ispit.Proizvodi
{
    public delegate void PredajIspit(Polaznik polaznik);

    public class Polaznik
    {
        public string ImePrezime { get; set; }

        public event PredajIspit IspitZavrsen;

        public void OdgovoriNaPitanja(DateTime vrijemePocetka)
        {
            Console.WriteLine("Ime i prezime polaznika: {0}", this.ImePrezime);
            Console.WriteLine("Datum i vrijeme početka ispita: {0}", vrijemePocetka);
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"Polaznik {this.ImePrezime} je predao odgovore na pitanja.");

            IspitZavrsen?.Invoke(this);
        }
    }
}
