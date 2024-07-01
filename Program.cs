using System;
using System.Collections.Generic;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrimjerListe();
            //PrimjerOsobe();

            try
            {
                var sadrzaj = DatotecniServis.OtvoriDatoteku("pero.txt");
            }
            catch (DatotecniException ex) 
            {
                Console.ForegroundColor = ex.Boja;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ResetColor();   
            }

            Console.Write("Kraj.");
            Console.ReadKey();
        }

        private static void PrimjerListe()
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
        }

        private static void PrimjerOsobe()
        {
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
        }
    }
}
