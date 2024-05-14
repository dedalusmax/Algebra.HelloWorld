using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ovo je početna točka izvršavanja programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // System.Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Ovo je tekst.");
            Console.Clear();

            var x = Math.Abs(-4); // funkcija vraća apsolutnu vrijednost
            var y = Math.Sqrt(x);

            Math.Sin(x);

            var ime = string.Concat("Pero", "Perić");
            Console.WriteLine(ime.Substring(4));

            long.TryParse("10000", out long broj);

            // IgrajSePisanja();
            // IgrajSePisanja();

            PrepisiTekst("bilo koji tekst", true);
            PrepisiTekst("običan tekst");

            string recenica = "Danas je kišno vrijeme";
            string[] niz = recenica.Split(' ');
            recenica.Substring(6);
            recenica.Substring(6, 2);

            Console.WriteLine(Program.ZbrojiDuplo(5));
            Console.WriteLine(Program.ZbrojiDuplo(45.25));

            Console.Clear();

            IspisiKorisnika("Pero Perić", 32, 42, 20000);
            IspisiKorisnika("Marta Martić", 25);
            IspisiKorisnika(ime: "Tonka Tonkić", brojCipela: 39, starost: 36);

            Console.ReadKey();
        }

        /// <summary>
        /// Ova metoda ispisuje tekst i ponavlja upisano.
        /// </summary>
        static void IgrajSePisanja()
        {
            Console.WriteLine("Ovo je prvi red.");
            Console.WriteLine("Ovo je drugi red.");
            var input = Console.ReadLine();
            Console.WriteLine($"Napisali ste: {input}");
        }

        static void PrepisiTekst(string tekst, bool istaknuto = false)
        {
            if (istaknuto)
            {
                Console.WriteLine(tekst.ToUpper());
                PrepisiTekst(tekst);
            }
            else
            {
                Console.WriteLine(tekst);
            }
        }

        static void IspisiKorisnika(string ime, int starost, int brojCipela = 0, double prihodi = 0.0)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Podaci o korisniku:\n");

            Console.BackgroundColor = ConsoleColor.Yellow;

            PrepisiTekst(ime, true);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("\nIme: {0}", ime);
            Console.WriteLine("Starost: {0}", starost);
    
            if (brojCipela > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Broj cipela: {0}", brojCipela);
            }

            if (prihodi > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Prihodi su: {0}", prihodi);
            }

            Console.WriteLine();
        }

        static int ZbrojiDuplo(int broj)
        {
            broj += broj;
            return broj;
        }

        static double ZbrojiDuplo(double broj)
        {
            broj += broj;
            return broj;
        }
    }
}
