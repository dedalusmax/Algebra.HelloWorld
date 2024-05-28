using System;

namespace HelloWorld
{
    internal abstract class Osoba
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string KorisnickiRacun { get; set; }

        public string Zaporka { get; set; }

        public bool Prijavljen { get; private set; }

        public int GodineIskustva { get; protected set; }

        public void Prijavi(string korisnickiRacun, string zaporka)
        {
            // logika prijave
            Prijavljen = true;
        }

        public virtual void UnesiRadnoVrijeme(DateTime vrijemeOd, DateTime vrijemeDo)
        {
            // logika ...
        }

        public abstract void UnesiGodineIskustva(int brojGodina);

        protected int IzracunajGodine()
        {
            return 35;
        }

        internal void InternaMetoda()
        {

        }

        private void NestoPrivatno()
        {

        }
    }
}
