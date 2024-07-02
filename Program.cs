using System;
using System.Collections.Generic;
using System.Linq;

namespace Algebra.HelloWorld
{
    public delegate void HelloWorldDelegate(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            // MetodaZaAnonimneTipove();
            // IspisiPozdrav();
            // Predikati();

            var jabuka = new Jabuka();
            jabuka.JabukaProdana += new EventHandler((o, e) => 
            {
                Console.WriteLine("Jabuka je prodana.");
            });

            jabuka.Kupi();

            jabuka.JabukaProdana -= new EventHandler((o, e) => { });

            Console.ReadKey();
        }

        private static void Predikati()
        {
            List<string> imena = new List<string>
            {
                "Pero", "Ana", "Ivana", "Marija", "Luka", "Marko"
            };

            Func<string, bool> uvjet = (string x) => { return x.StartsWith("M"); };

            var potraga = imena.Find(x => x.StartsWith("M"));
            // var skracenice = imena.Select(x => x.Substring(0, 3));
            var skracenice = imena.Select(uvjet);
        }

        private static void LokalnaMetoda()
        {
            void delegat(string message)
            {
                delegat(message);
                Console.WriteLine($"Hello! " + message);
            }
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

    internal class Jabuka
    {
        public event EventHandler JabukaProdana;

        public void Kupi()
        {
            JabukaProdana?.Invoke(this, EventArgs.Empty);
        }
    }
}
