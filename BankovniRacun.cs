using System;

namespace HelloWorld
{
    internal class BankovniRacun
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
