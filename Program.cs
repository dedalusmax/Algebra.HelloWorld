using System;
using System.Linq;

namespace Algebra.HelloWorld
{
    public delegate void HelloWorldDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            // MetodaZaAnonimneTipove();
            IspisiPozdrav();

            Console.ReadKey();
        }

        private static void IspisiPozdrav()
        {
            string ime = "Pero";

            HelloWorldDelegate delegat = delegate (string message)
            {
                Console.WriteLine($"Hello {ime}! " + message);
            };

            delegat.Invoke("hello!");
            delegat("pozdrav!");

            IspisiTekstove(delegat, "Ana");
        }

        private static void IspisiTekstove(HelloWorldDelegate delegat, string poruka)
        {
            delegat.Invoke(poruka);
        }

        private static void MetodaZaAnonimneTipove()
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
