using HelloWorld;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilderTest();
            // ObjectTests();
            // CollectionsTest();

            Console.ReadKey();
        }

        private static void CollectionsTest()
        {
            var lista = new List<Racun>();
            lista.Add(new Racun());
            lista.Add(new Racun());
            lista[lista.Count - 1] = new Racun();
            lista.Clear();

            var red = new Queue<string>(); // FIFO = first in, first out
            red.Enqueue("Pero");
            red.Enqueue("Marko");
            red.Enqueue("Ana");
            var slijedeci = red.Dequeue();
            slijedeci = red.Dequeue();

            var stog = new Stack<int>(); // LIFO = last in, first out
            stog.Push(1);
            stog.Push(2);
            stog.Push(3);
            var palacinka = stog.Pop();
            var proviri = stog.Peek();

            var tablica = new Hashtable();
            tablica.Add(1, "Pero");
            tablica.Add(true, "Marko");

            var rijecnik = new Dictionary<int, string>();
            rijecnik.Add(1, "Pero");
            rijecnik.Add(2, "Marko");
            var sadrzaj = rijecnik.Values;
            var rezultat = rijecnik.ContainsValue("Iva");
            var kljuc = rijecnik.ContainsKey(2);

            // System.Collections.Concurrent
        }

        private static void ObjectTests()
        {
            var racun1 = new Racun
            {
                Sifra = 100,
                Naziv = "Tekući",
                Stanje = 100.00
            };

            var racun2 = new Racun
            {
                Sifra = 100,
                Naziv = "Tekući",
                Stanje = 100.00
            };

            //var racun2 = new Racun
            //{
            //    Sifra = 102,
            //    Naziv = "Žiro",
            //    Stanje = 50.00
            //};

            // var racun2 = racun1;

            var x = (racun1 == racun2);
            var y = (racun1.Equals(racun2));
            var z = (racun1 == racun1);
            var tip = racun1.GetType();
            var kod1 = racun1.GetHashCode();
            var kod2 = racun2.GetHashCode();

            var lista = new List<Racun>
            {
                racun1,
                racun2
            };
            lista.Sort();
        }

        private static void StringBuilderTest()
        {
            // 1. string builder

            string tekst = "Pero Perić";
            tekst += " je top zaposlenik!";
            tekst += "\n\n\rsredina teksta.";

            // Console.Write(tekst);

            var builder = new StringBuilder();
            builder.Append(tekst);
            builder.AppendLine("još toga u liniji.");
            builder.AppendFormat("Cijena je: {0:C}", 50.00);

            Console.WriteLine(builder.ToString());
        }
    }
}
