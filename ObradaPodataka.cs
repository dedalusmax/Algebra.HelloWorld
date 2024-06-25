using System;
using System.Threading;

namespace HelloWorld
{
    public delegate bool ProcesZavrsenDelegate();

    internal class ObradaPodataka
    {
        public event ProcesZavrsenDelegate ProcesZavrsen;

        public bool PokreniProces()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Proces u tijeku, faza {0}", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Proces završen uspješno!");

            ProcesZavrsen.Invoke();

            return true;
        }
    }
}
