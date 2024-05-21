using System;

namespace HelloWorld
{
    public class Osoba
    {
        //public string Ime;
        //public string Prezime;
        //public int Starost;

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

        public Osoba()
        {

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
