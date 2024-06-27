using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int strikni = 10;
            //Nullable<int> slobodni = null;
            int? slobodni = null;

            strikni = slobodni ?? 25;

            slobodni += 2;

            //strikni += slobodni.Value;

            strikni += slobodni.GetValueOrDefault();

            if (!slobodni.HasValue)
            {
                Console.WriteLine("varijabla je null");
            }

            Console.WriteLine(strikni);
            Console.WriteLine(slobodni);

            Console.ReadKey();
        }

        private class Osoba
        {
            public int Sifra { get; set; }

            public string Ime { get; set; }

            public Nullable<int> OIB { get; set; }
        }
    }
}
