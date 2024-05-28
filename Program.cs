using HelloWorld.Models;
using System;

namespace HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ovo je početna točka izvršavanja programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var racun = new BankovniRacun();
            racun.Info();
            Console.ReadLine();

            racun.Uplati(500.00);
            racun.Info();
            Console.ReadLine();

            racun.Isplati(1200.00);
            racun.Info();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
