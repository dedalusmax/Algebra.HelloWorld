using System;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rijec = " Algebra  ";

            Console.WriteLine(rijec);

            // operacije/metode nad varijablom:

            Console.WriteLine(rijec.ToLower());
            Console.WriteLine(rijec.ToUpper());
            Console.WriteLine(rijec.TrimStart(' '));
            Console.WriteLine(rijec.TrimEnd(' '));
            Console.WriteLine(rijec.Trim());

            // svojstva varijable:
            
            Console.WriteLine(rijec.Length);
            Console.WriteLine(rijec.TrimStart(' ').Length);
            Console.WriteLine(rijec.TrimEnd(' ').Length);
            Console.WriteLine(rijec.Trim().Length);

            char a = 'a';
            char l = 'l';
            char g = 'g';
            char e = 'e';
            char b = 'b';
            char r = 'r';

            Console.WriteLine("" + a + l + g + e + b + r + a);
            Console.WriteLine(string.Concat(a, l, g, e, b, r, a));

            // escape characters: \n \\ \" \'
            Console.WriteLine("Ovo je neki,\n teks \\ t u \"navodnicima\" !?");

            int broj = 1024;
            Console.WriteLine(broj);
            Console.WriteLine(broj.ToString());

            Convert.ToString(broj);
            Int32.Parse(broj.ToString());

            Console.WriteLine(a + l + g + e + b + r + a);
            var kod = char.GetNumericValue(a);

            // string je niz znakova:

            string jelo = "Lasagna";
            Console.WriteLine(jelo.First());
            Console.WriteLine(jelo.Last());
            Console.WriteLine(jelo.Substring(1));
            Console.WriteLine(jelo.Substring(2, 3));
            Console.WriteLine(jelo.IndexOf('n'));
            Console.WriteLine(jelo.IndexOf("gn"));
            Console.WriteLine(jelo.IndexOf('ž'));

            string recenica = "Jedna obična rečenica";
            string[] rijeci = recenica.Split(' ');

            string red = "1234;Pero;Perić;ulica;14"; // CSV

            Console.WriteLine(red.Replace("Pero", "Marko"));

            var polja = red.Split(';');
            Console.WriteLine(red.Split(';').Last());

            var x = Int32.Parse(red.Split(';').First()).ToString().Split().Length;

            Console.ReadKey();
        }
    }
}
