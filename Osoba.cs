using System;

namespace Algebra.HelloWorld
{
    public class Osoba
    {
        public int? OIB { get; set; }

        public string Ime { get; set; }

        public Racun TekuciRacun { get; set; }

        public Osoba(string ime)
        {
            Ime = ime;
        }

        public Osoba(string ime, int oib)
        {
            Ime = ime;
            OIB = oib;
        }

        public void PostaviStanjeRacuna()
        {
            try
            {
                this.TekuciRacun.Stanje = 0;
            }
            catch (NullReferenceException ex)
            {
                throw new ApplicationException("Inicijalizacija računa nije uspjela.", ex);
            }
        }
    }

}
