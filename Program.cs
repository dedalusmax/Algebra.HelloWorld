using HelloWorld;
using System;

namespace Algebra.HelloWorld
{
    internal class Program : IDisposable
    {
        static void Main(string[] args)
        {
            var obrada = new ObradaPodataka();

            obrada.FazaZavrsena += FazaObradeZavrsena;
            obrada.ProcesZavrsen += ProcesObradeZavrsen;

            obrada.PokreniProces();

            // tralala

            Console.ReadKey();

            obrada.FazaZavrsena -= FazaObradeZavrsena;
            obrada.ProcesZavrsen -= ProcesObradeZavrsen;

            obrada.PokreniRucnoFazu(12);
        }

        private static void FazaObradeZavrsena(object sender, byte brojFaze)
        {
            Console.WriteLine("Proces u tijeku, faza {0} završena.", brojFaze);
        }

        private static void ProcesObradeZavrsen(object sender, EventArgs e)
        {
            Console.WriteLine("Dočekali kraj procesa.");
        }

        public void Dispose()
        {
            Console.WriteLine("Gasim program.");
        }
    }
}
