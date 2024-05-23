using HelloWorld;
using System;
using System.Collections;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var osoba = new Osoba();
            //osoba.Ime = "Pero";
            //osoba.Prezime = "Perić";
            
            //Console.WriteLine(osoba.IzracunajGodine());

            var zaposlenik = new Zaposlenik();
            zaposlenik.Ime = "Marko";
            zaposlenik.Prezime = "Marković";

            Console.WriteLine(zaposlenik.IzracunajGodine());

            var admin = new Administrator();
            admin.Ime = "Marta";
            admin.Prezime = "Martić";
            admin.ZadajPravaPristupa();

            var popisPjesama = new ShuffledArrayList();
            popisPjesama.Shuffle();

            var cudniKorisnik = new Haker();
            //cudniKorisnik.ZadajPravaPristupa();

            Console.ReadKey();
        }
    }

    internal class ShuffledArrayList : ArrayList
    {
        public ShuffledArrayList()
        {

        }

        public void Shuffle()
        {
            foreach (var item in this)
            {
                // shuffle
            }
        }
    }
}
