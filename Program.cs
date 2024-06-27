using HelloWorld;
using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obrada = new ObradaPodataka();

            obrada.ProcesZavrsen += ProcesObradeZavrsen;

            obrada.PokreniProces();

            // tralala

            Console.ReadKey();
        }

        private static bool ProcesObradeZavrsen()
        {
            Console.WriteLine("Dočekali kraj procesa.");
            return true;
        }
    }
}
