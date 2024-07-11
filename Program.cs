using Ispit.Proizvodi;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var predavac = new Predavac();

            var polaznici = new List<Polaznik>
            {
                new Polaznik() { ImePrezime = "Pero Perić" },
                new Polaznik() { ImePrezime = "Iva Ivić" },
                new Polaznik() { ImePrezime = "Marko Marković" },
                new Polaznik() { ImePrezime = "Marta Martić" },
            };

            polaznici.ForEach(p => p.IspitZavrsen += (polaznik) => 
            { 
                predavac.IspitZaprimljen(polaznik);
            });

            predavac.Ispit += (DateTime startTime) =>
            {
                foreach (var polaznik in polaznici)
                {
                    polaznik.OdgovoriNaPitanja(DateTime.Now);
                }
            };

            predavac.ZvoniZvono();

            Thread.Sleep(1000);

            polaznici[2].PredajOdgovoreNaPitanja();

            Console.ReadKey();
        }
    }
}
