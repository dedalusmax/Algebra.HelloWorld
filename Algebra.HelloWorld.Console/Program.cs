using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OUTFIT STORE");
            Console.WriteLine("Please make your order!");

            while (true) 
            {
                Console.WriteLine("Make your pick from the outlets we have in store:");

                Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
