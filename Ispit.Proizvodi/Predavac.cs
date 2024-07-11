using System;

namespace Ispit.Proizvodi
{
    public class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Cin-cin! Ispit počinje!");

            Ispit?.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine("Ispit zaprimljen od polaznika: {0}", polaznik.ImePrezime);
        }
    }
}
