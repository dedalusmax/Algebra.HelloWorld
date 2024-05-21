using System;
using System.Collections;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ovo je početna točka izvršavanja programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // RadiSaJabukama();

            // RadiSaRacunima();

            Osoba osoba1 = new Osoba();
            osoba1.Ime = "Pero";
            osoba1.Prezime = "Perić";
            osoba1.DatumRodjenja = new DateTime(1994, 01, 01);
            Console.WriteLine(osoba1.VratiPunoIme());
            Console.WriteLine(osoba1.Starost);

            Osoba osoba2 = new Osoba();
            osoba2.Ime = "Mara";
            osoba2.Prezime = "Marić";
            osoba2.DatumRodjenja = new DateTime(2000, 04, 01);
            Console.WriteLine(osoba2.VratiPunoIme());
            Console.WriteLine(osoba2.Starost);

            Console.ReadKey();
        }

        private static void RadiSaRacunima()
        {
            var racun = new BankovniRacun();
            racun.Info();
            Console.ReadLine();

            racun.Uplati(500.00);
            racun.Info();
            Console.ReadLine();

            racun.Isplati(1200.00);
            racun.Info();
            Console.ReadLine();

            Console.Clear();
        }

        private static void RadiSaJabukama()
        {
            Jabuka jabuka1 = new Jabuka();
            jabuka1.IspisiSvojstva();

            //jabuka1.Boja = "žuta";
            jabuka1.TezinaG += 20;

            jabuka1.IspisiSvojstva();

            jabuka1 = null;

            Jabuka jabuka2 = new Jabuka("crvena", 75);
            jabuka2.Kupi();

            Jabuka jabuka3 = new Jabuka();
            jabuka3.BioUzgoj = true;
            jabuka3.Kupi();

            Console.Clear();
        }
    }

    class Test
    {
        Test() 
        {
            var osoba = new Osoba();
            var racun = new BankovniRacun();
            var jabuka = new Jabuka();
        }
    }

    class Jabuka
    {
        // privatne varijable
        private string _boja;
        private double _tezinaG;
        private bool _bioUzgoj;

        #region svojstva

        //public string Boja;

        public string Boja
        { 
            get { return _boja; }
        }

        //public double TezinaG;

        public double TezinaG
        {
            get { return _tezinaG; }
            set { _tezinaG = value; }
        }

        //public bool BioUzgoj;
        public bool BioUzgoj
        {
            set { _bioUzgoj = value; }
        }

        public string Oblik { get; set; }

        #endregion

        // konstruktori
        public Jabuka() 
        {
            Console.WriteLine("Konstrukcija objekta.");

            _boja = "zelena";
            TezinaG = 80;
        }

        public Jabuka(string boja, double tezinaG)
        {
            _boja = boja;
            TezinaG = tezinaG;
        }

        #region metode

        public void Kupi()
        {
            Console.WriteLine("Metoda Kupi je pozvana.");
        }

        public void Uberi()
        {
        }

        public void IspisiSvojstva()
        {
            Console.WriteLine($"Boja: {_boja}");
            Console.WriteLine($"BioUzgoj: {_bioUzgoj}");
            Console.WriteLine($"Težina (u gramima): {_tezinaG}");
        }

        #endregion

        // privatne metode
    }

    public class BankovniRacun
    {
        private long _broj;
        private double _stanje;
        private string _vrsta;       

        public BankovniRacun()
        {
            _broj = 123456789;
            _stanje = 0.0;
            _vrsta = "žiro";
        }

        public void Uplati(double iznos)
        {
            _stanje += iznos;
        }

        public void Isplati(double iznos)
        {
            _stanje -= iznos;

            if (_stanje < 0) Console.Beep();
        }

        public void Info()
        {
            Console.WriteLine($"Broj računa: {_broj}");
            Console.WriteLine($"Vrsta računa: {_vrsta}");

            if (_stanje > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (_stanje < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine("Stanje računa: {0:0.00} EUR", _stanje);

            Console.ResetColor();
        }
    }

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
