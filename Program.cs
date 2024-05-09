using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList kolekcija = new ArrayList();
            kolekcija.Add(1);
            kolekcija.Add("Sir");
            kolekcija.Add(true);
            kolekcija.Add("Sir");
            kolekcija.Add("Sir");

            Console.WriteLine(kolekcija[0]);
            Console.WriteLine(kolekcija[1]);
            Console.WriteLine(kolekcija[2]);

            Console.WriteLine(kolekcija.Count);

            Console.WriteLine(kolekcija.Contains(1));
            Console.WriteLine(kolekcija.Contains("Mlijeko"));
            
            kolekcija.RemoveAt(0);
            kolekcija.Remove("Sir");
            kolekcija.Clear();

            if (kolekcija.Contains(150))
            {
            }

            // generičke liste

            int[] nizBrojeva = new int[3];
            ArrayList kolekcijaBrojeva = new ArrayList(); // i drugi tipovi!!

            List<int> brojevi = new List<int>(); // samo int-ovi
            brojevi.Add(25);
            brojevi.Add(50);
            brojevi.Add(75);
            brojevi.Add(100);

            foreach (int i in brojevi) 
            { 
                Console.WriteLine(i);
            }

            string[] namirnice = new string[] { "Med", "Kruh", "Jaja", "Salata", "Kulen" };
            var popis = string.Empty;
            foreach (string n in namirnice)
            {
                popis += ", " + n;
            }
            Console.WriteLine(popis);

            // for petlja
            popis = "";
            for (int i = 0; i < 5; i++)
            {
                popis += ", " + namirnice[i];
            }
            Console.WriteLine(popis);

            popis = "";
            for (int j = 4; j >= 0; j--) // (namirnice.Length - 1)
            {
                popis += ", " + namirnice[j];
            }
            Console.WriteLine(popis);

            for (int x = 0; x < 5; x++)
            {
                if (x == 3)
                {
                    //break;
                    continue;
                }

                Console.WriteLine(x);
            }

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine("{0},{1}", x, y);
;                }
            }

            Console.ReadKey();
        }
    }
}
