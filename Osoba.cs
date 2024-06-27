using System;

namespace HelloWorld
{
    internal class Osoba
    {
        public int Sifra { get; set; }

        public string Ime { get; set; }

        public Racun TekuciRacun { get; set; }

        public Racun ZiroRacun { get; set; }

        public Osoba()
        {
            TekuciRacun = new Racun();
            TekuciRacun.StanjePromjenjeno += StanjeRacunaPromjenjeno;

            ZiroRacun = new Racun();
            ZiroRacun.StanjePromjenjeno += StanjeRacunaPromjenjeno;
        }

        private void StanjeRacunaPromjenjeno(object sender, double novoStanje)
        {
            Console.WriteLine("Novo stanje ovog računa je {0:C}", novoStanje);
        }
    }
}
