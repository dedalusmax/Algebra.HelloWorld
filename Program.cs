using System;
using System.Collections.Generic;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
