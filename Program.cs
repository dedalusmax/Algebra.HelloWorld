using System;

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

            var racun = new BankovniRacun();
            racun.Info();
            Console.ReadLine();

            racun.Uplati(500.00);
            racun.Info();
            Console.ReadLine();

            racun.Isplati(1200.00);
            racun.Info();
            Console.ReadLine();
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
}
