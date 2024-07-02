using HelloWorld;
using System;

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

    public static class BezopasnaKlasa
    {
        public static void Isplata(this Racun racun, double iznos)
        {
            racun.Stanje -= iznos;
        }

        public static void Print(this string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
