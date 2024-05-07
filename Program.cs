using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vremenska prognoza:

            // ispisati tekst vremena i mogućnosti za kišu:

            Console.Write("Kakvo je vrijeme? ");
            string vrijeme = Console.ReadLine(); // oblacno, vedro

            Console.Write("Da li je mogućnost kiše? ");
            string kisa = Console.ReadLine(); // da/ne

            // priprema
            bool moguca_kisa = (kisa == "da");

            // obrada
            if (vrijeme == "oblacno")
            {
                Console.Write("Vrijeme je oblačno. ");

                if (moguca_kisa)
                {
                    Console.WriteLine("Ponesite kišobran!");
                }
                else
                {
                    Console.WriteLine("Ali ne brinite, neće biti kiše. ;)");
                } 
            }
            else
            {
                Console.WriteLine("Vrijeme će biti prekrasno. :)");
            }

            Console.ReadKey();
        }
    }
}
