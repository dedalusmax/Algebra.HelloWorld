using System;
using System.Linq;
using HelloWorld.Models;

namespace HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ovo je početna točka izvršavanja programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //RadiSaJabukama();

            //RadiSaRacunima();
            
            Osoba osoba1 = new Osoba();
            osoba1.Ime = "Pero";
            osoba1.Prezime = "Perić";
            osoba1.DatumRodjenja = new DateTime(1994, 01, 01);
            MyConsole.WriteLine(osoba1.VratiPunoIme());
            MyConsole.WriteLine(osoba1.Starost.ToString());
            Console.WriteLine($"Redni broj osobe: {Osoba.RedniBroj}");

            osoba1.DodajRacun(123213213213, "tekući", 100.00);
            osoba1.Racun.Uplati(40.00);
            
            Osoba osoba2 = new Osoba();
            osoba2.Ime = "Mara";
            osoba2.Prezime = "Marić";
            osoba2.DatumRodjenja = new DateTime(2000, 04, 01);
            Console.WriteLine(osoba2.VratiPunoIme());
            Console.WriteLine(osoba2.Starost);
            Console.WriteLine($"Redni broj osobe: {Osoba.RedniBroj}");

            var program = new ProgramObrazovanja("ASP.NET Developer", "OL-OASP_DEV_H-02/24");
            program.Polaznici.AddRange(new[] { osoba1, osoba2, osoba1, osoba2, osoba2 });
            program.ListaModula.AddRange(new[] { new Modul(1, "Uvod u C#"), new Modul(2, "Uvod u baze podataka") });

            var brojPolaznika = program.Polaznici.Count;
            var zadnjiModul = program.ListaModula.Last();

            Calc.Median(new[] { 10.0, 20, 50 });

            osoba1 = null;
            osoba2 = null;

            GC.Collect();

            Console.ReadKey();
        }

        private static void RadiSaRacunima()
        {
            var racun = new BankovniRacun();
            racun.Info();
            Console.ReadLine();
            
            racun.Uplati(500.00);
            racun.Info();
            Console.ReadLine();

            racun.Isplati(1200.00);
            racun.Info();
            Console.ReadLine();

            Console.Clear();
        }

        private static void RadiSaJabukama()
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

            Console.Clear();
        }

        private class Test
        {
            Test()
            {
                var osoba = new Osoba();
                var racun = new BankovniRacun();
                var jabuka = new Jabuka();
            }
        }
    }
}
