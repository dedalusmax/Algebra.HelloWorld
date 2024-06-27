using System;
using System.Threading;

namespace HelloWorld
{
    public delegate bool ProcesZavrsenDelegate();

    internal class ObradaPodataka
    {
        public event EventHandler<byte> FazaZavrsena;
        public event EventHandler ProcesZavrsen;
        //public event ProcesZavrsenDelegate ProcesZavrsen;

        public bool PokreniProces()
        {
            for (byte i = 1; i <= 10; i++)
            {
                //Console.WriteLine("Proces u tijeku, faza {0}", i);
                //Thread.Sleep(1000);
                FazaZavrsena.Invoke(this, i);
            }

            //Console.WriteLine("Proces završen uspješno!");

            ProcesZavrsen?.Invoke(this, new EventArgs());

            return true;
        }

        public void PokreniRucnoFazu(byte faza)
        {
            Thread.Sleep(1000);
            FazaZavrsena?.Invoke(this, faza);
        }
    }
}
