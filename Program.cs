using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ocjena = 4;

            if (ocjena == 1)
            {
                Console.WriteLine("Ocjena nije zadovoljavajuća.");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("Ocjena je dovoljan.");
            }
            else if (ocjena == 3)
            {
                Console.WriteLine("Ocjena je dobar.");
            }
            else if (ocjena == 4)
            {
                Console.WriteLine("Ocjena je vrlo dobar.");
            }
            else // ocjena == 5
            {
                Console.WriteLine("Ocjena je odličan.");
            }

            double prosjek = 2.5;

            if (prosjek >= 2.5 && prosjek < 3.5)
            {
                // ocjena 3
                if (prosjek >= 2.5 && prosjek < 3.0)
                {
                    Console.WriteLine("Nešto niža trojka.");

                    if (prosjek == 2.5)
                    {
                        Console.WriteLine("Svaka čast!");
                    }
                }
                else
                {
                    Console.WriteLine("Jaka trojka.");
                }
            }

            if (prosjek == 2.5)
            {
                Console.WriteLine("Svaka čast!");
            } 
            else if (prosjek < 3.0)
            {
                Console.WriteLine("Nešto niža trojka.");
            }
            else if (prosjek < 3.5)
            {
                Console.WriteLine("Jaka trojka.");
            }

            bool odlikas;

            // normalni oblik

            if (prosjek >= 4.5)
            {
                odlikas = true;
            }
            else
            {
                odlikas = false;
            }

            // kondenzirani oblik

            if (prosjek >= 4.5)
                odlikas = true;
            else
                odlikas = false;

            if (odlikas)
                odlikas = true;

            // jednolinijski oblik

            if (odlikas) odlikas = true;

            odlikas = (prosjek >= 4.5) ? true : false;

            odlikas = (prosjek >= 4.5);

            string rezultat = (prosjek >= 4.5) ? "Odlikaš" : "Nije odlikaš";

            var x = (1 == 2) && (1 > 3) ? (2 == 3) ? (23) : 2323 : 23;

            // optimirano

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Ocjena nije zadovoljavajuća."); break;
                case 2:
                    Console.WriteLine("Ocjena je dovoljan."); break;
                case 3:
                    Console.WriteLine("Ocjena je dobar."); break;
                case 4:
                    Console.WriteLine("Ocjena je vrlo dobar."); break;
                default:
                    Console.WriteLine("Ocjena je odličan."); break;
            }

            Console.ReadKey();
        }
    }
}
