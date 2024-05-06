using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = "Pero";

            Console.WriteLine("Pozdrav, " + ime + "!");
            Console.WriteLine($"Pozdrav, {ime}!");
            Console.WriteLine("Pozdrav, {0}!", ime);

            Console.Write("Pozdrav, ");
            Console.Write(ime);
            Console.WriteLine("!");

            Console.Write("Pozdrav, " + ime + "!\n");
            
            int godine = 25;

            Console.WriteLine(godine);

            Console.WriteLine("Pozdrav, {0} sa {1} godina", ime, godine);

            var a = "100";
            var b = 200;
            var c = Int64.Parse(a) + b;
            var d = Convert.ToInt16(a);

            var e = Int64.TryParse("abc", out var f);

            // var unos = Console.ReadLine();
            // double rezultat = Convert.ToDouble(unos);

            var rezultat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(rezultat * 1.25);
        }
    }
}
