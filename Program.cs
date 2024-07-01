using System;
using System.Collections.Generic;
using System.Linq;
using static Algebra.HelloWorld.Program;

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

            try
            {
                Console.WriteLine(lista[3]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ex.Message);
                Console.WriteLine(lista.LastOrDefault());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ResetColor();
            }

            // klase

            var osoba = new Osoba("Pero");

            try
            {
                osoba.PostaviStanjeRacuna();
            }
            catch (ApplicationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ResetColor();
            }

            Console.Write("Kraj.");
            Console.ReadKey();
        }

        public class Osoba
        {
            public int? OIB { get; set; }

            public string Ime { get; set; }

            public Racun TekuciRacun { get; set; }

            public Osoba(string ime)
            {
                Ime = ime;
            }

            public Osoba(string ime, int oib)
            {
                Ime = ime;
                OIB = oib;
            }

            public void PostaviStanjeRacuna()
            {
                try
                {
                    this.TekuciRacun.Stanje = 0;
                }
                catch (NullReferenceException ex)
                {
                    throw new ApplicationException("Inicijalizacija računa nije uspjela.", ex);
                }
            }
        }

        public class Racun
        {
            public string Naziv { get; set; }

            public double Stanje { get; set; }
        }
    }
}
