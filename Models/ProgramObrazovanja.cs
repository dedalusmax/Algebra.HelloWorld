using System.Collections.Generic;

namespace HelloWorld.Models
{
    internal class ProgramObrazovanja
    {
        public string Naziv { get; set; }

        public string Grupa { get; set; }

        public List<Modul> ListaModula { get; set; } // = new List<Modul>();

        public List<Osoba> Polaznici { get; set; }

        internal ProgramObrazovanja(string naziv, string grupa) 
        {
            Naziv = naziv;
            Grupa = grupa;
            ListaModula = new List<Modul>();
            Polaznici = new List<Osoba>();
        }
    }
}
