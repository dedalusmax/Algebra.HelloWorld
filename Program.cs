using System;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metoda();

            Console.ReadKey();
        }

        private static void Metoda()
        {
            var ime = "Pero";
            var id = 10;

            var polaznik = new { Id = 1, Ime = "Marko" };

            // polaznik.Id = 200;
            Console.WriteLine($"Id: {polaznik.Id}, Ime: {polaznik.Ime}");

            var osoba = new
            {
                Sifra = 100,
                Ime = "Pero",
                Prezime = "Perić",
                GodinaRodjenja = 2000,
                Racun = new { Sifra = 1, Tip = "Tekući", Stanje = 100.00F }
            };

            PozivnaMetoda(osoba);

            var rezultat = PovratnaMetoda();
        }
    
        internal static void PozivnaMetoda(object osoba)
        {
        }

        protected static object PovratnaMetoda()
        {
            var polaznici = new[]
{
                new { Id = 1, Ime = "Marko" },
                new { Id = 2, Ime = "Ana" }
            };

            var zadnji = polaznici.LastOrDefault();
            Console.WriteLine(zadnji.Ime);

            return zadnji;
        }
    }
}
