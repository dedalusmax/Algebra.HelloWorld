using System;
using System.Diagnostics.Eventing.Reader;

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

            Console.ReadKey();
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

}
