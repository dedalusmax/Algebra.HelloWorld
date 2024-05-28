﻿using System;

namespace HelloWorld.Models
{
    internal class BankovniRacun
    {
        internal long Broj { get; private set; }

        internal double Stanje { get; private set; }

        internal string Vrsta { get; private set; }

        public BankovniRacun()
        {
            //_broj = 123456789;
            //_stanje = 0.0;
            //_vrsta = "žiro";
        }

        public BankovniRacun(long broj, string vrsta, double stanje)
        {
            Broj = broj;
            Vrsta = vrsta;
            Stanje = stanje;
        }

        public void Uplati(double iznos)
        {
            Stanje += iznos;
        }

        public void Isplati(double iznos)
        {
            Stanje -= iznos;

            if (Stanje < 0) Console.Beep();
        }

        public void Info()
        {
            Console.WriteLine($"Broj računa: {Broj}");
            Console.WriteLine($"Vrsta računa: {Vrsta}");

            if (Stanje > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (Stanje < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine("Stanje računa: {0:0.00} EUR", Stanje);

            Console.ResetColor();
        }
    }
}
