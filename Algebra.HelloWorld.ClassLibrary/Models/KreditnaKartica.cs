using Algebra.HelloWorld.ClassLibrary.Interfaces;
using System;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public class KreditnaKartica : ISredstvoPlacanja, IBezgotovinskoPlacanje
    {
        public double Stanje { get; set; }

        internal string Broj { get; private set; }

        public KreditnaKartica(string broj, double stanje)
        {
            Broj = broj;
            Stanje = stanje;
        }

        public void Info()
        {
            Console.WriteLine($"Broj kartice: {Broj}");

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

            Console.WriteLine("Stanje kartice: {0:0.00} EUR", Stanje);

            Console.ResetColor();
        }

        public void Isplati(double iznos)
        {
            Stanje -= iznos;
        }

        public void Uplati(double iznos)
        {
            Stanje += iznos;
        }
    }
}
