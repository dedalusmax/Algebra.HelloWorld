using HelloWorld;
using HelloWorld.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tekst = "Pero Perić";
            tekst.Print();
            tekst.Print(ConsoleColor.Green);
            
            ProsirivanjeRacuna();

            List<int> brojevi = new List<int>() { 1, 43, 23, 45, 56, 34, 76, 8 };
            var slucajniBroj = brojevi.Randomize();

            Console.ReadKey();
        }

        private static void ProsirivanjeRacuna()
        {
            var racun = new Racun
            {
                Naziv = "Tekući račun"
            };

            racun.Uplata(50.00);
            Console.WriteLine(racun.Stanje);

            // tweak-anje isplate
            racun.Uplata(-20.00);
            Console.WriteLine(racun.Stanje);

            racun.Isplata(30.00);
            Console.WriteLine(racun.Stanje);

            racun.Naziv.Print(ConsoleColor.Red);
        }
    }

    public static class Nebitno
    {
        public static int Randomize(this List<int> list)
        {
            Random random = new Random();
            return random.Next(list.Count);    
        }
    }

}
