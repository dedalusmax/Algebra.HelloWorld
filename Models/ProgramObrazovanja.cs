using System.Collections.Generic;

namespace HelloWorld.Models
{
    internal class ProgramObrazovanja
    {
        public string Naziv { get; set; }

        public string Grupa { get; set; }

        public List<Modul> ListaModula { get; set; } // = new List<Modul>();

        public List<Osoba> Polaznici { get; set; }

        internal ProgramObrazovanja() 
        {
            ListaModula = new List<Modul>();
            Polaznici = new List<Osoba>();
        }
    }
}
