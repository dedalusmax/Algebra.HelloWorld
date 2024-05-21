using System;

namespace HelloWorld.Models
{
    public class Osoba
    {
        private string _ime;
        private string _prezime;
        private int _starost;
        private DateTime _datumRodjenja;

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public int Starost
        {
            get { return _starost; }
        }

        public DateTime DatumRodjenja
        {
            set
            {
                _datumRodjenja = value;
                IzracunajStarost();
            }
        }

        internal BankovniRacun Racun { get; set; }

        public Osoba()
        {

        }

        public void DodajRacun(long broj, string vrsta, double stanje)
        {
            Racun = new BankovniRacun(broj, vrsta, stanje);
        }

        public string VratiPunoIme()
        {
            return $"{_ime} {_prezime}";
        }

        private void IzracunajStarost()
        {
            _starost = DateTime.Today.Year - _datumRodjenja.Year;
        }
    }
}
