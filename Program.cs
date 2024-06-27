using System;
using System.Collections.Generic;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>
            {
                "Pero",
                "Iva",
                "Marko"
            };

            var rezultat = lista.FindAll(x => x.Equals("Pero"));

            string imena = string.Empty;
            //lista.ForEach(x => { imena += x; });
            //lista.ForEach((x) => imena += x);
            lista.ForEach(x => imena += x);

            List<Osoba> osobe = new List<Osoba>
            {
                new Osoba("Pero"),
                new Osoba("Iva"),
                new Osoba("Marko"),
            };

            var imena2 = osobe.Select(x => x.Ime).ToList();

            Action akcija = () => Console.WriteLine("Akcija izvršena!");
            akcija.Invoke();

            // Func<string, bool> funkcija = (x) => true;
            Func<string, int, Osoba> kreirajOsobu = (ime, oib) => { return new Osoba(ime, oib); };

            kreirajOsobu("Pero", 123);

            Func<string, int, Osoba> delegat = delegate (string s, int x) { 
                return new Osoba(s); 
            };

            Console.ReadKey();
        }

        public class Osoba 
        {
            public int? OIB { get; set; }

            public string Ime { get; set; }

            public Osoba(string ime)
            {
                Ime = ime;
            }

            public Osoba(string ime, int oib)
            {
                Ime = ime;
                OIB = oib;
            }
        }
    }
}
