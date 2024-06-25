using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        public delegate void TestDelegate(string tekst);

        static void Main(string[] args)
        {
            TestDelegate del1 = MetodaA;

            del1.Invoke("prvi puta");
            del1.Invoke("drugi puta");

            Console.ReadKey();
        }

        public static void MetodaA(string tekst)
        {
            Console.WriteLine($"Ivršavamo metodu A sa tekstom: {tekst}.");
        }
    }
}
