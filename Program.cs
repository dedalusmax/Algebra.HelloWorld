using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ZADACI ZA VJEŽBU – Modul 01:

            /*
            Ciklične petlje
            TURA 1:
            1.	Primjer konačne while petlje koja ima uvjet ako je x manji od 10
            2.	Primjer konačne while petlje koja ima uvjet ako je y veći od 0
            3.	Beskonačna petlja, ali uz pomoć naredbe break; je moguće izaći iz petlje
            4.	Primjer while petlje za unos ocjena. Ocjene moraju biti brojevi između 1 i 5
            5.	Program za brojanje ukupnog broja slova, znamenki i posebnih znakova u nizu
            */

            int x = 1;
            while (x < 10)
            {
                x++;
            }

            int y = 10;
            while (y > 0)
            {
                y--;
            }

            int tajniBroj = 4;
            int input;

            for (int i = 0; 0 < 5; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());

                if (input == tajniBroj)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pogrešan broj, pokušajte ponovo.");
                }
            }

            var endNumber = 10;
            while (true)
            {
                Console.WriteLine($"Zadatak 3: Beskonačna petlja iteracija: {endNumber}");
                if (endNumber == 20)
                {
                    Console.WriteLine($"Zadatak 3: Izlaz iz petlje {endNumber}");
                    break;
                }
                endNumber++;
            }

            int ocijena;
            while (true)
            {
                Console.WriteLine("Unesite ocjenu od 1 do 5");
                ocijena = int.Parse(Console.ReadLine());
                if (ocijena < 1 || ocijena > 5)
                {
                    Console.WriteLine("Pogresan unos");
                    continue;
                }
                else
                {
                    Console.WriteLine("Uspjesan unos ocijene");
                    break;
                }

            }

            string niz;
            int slova = 0;
            int znamenki = 0;
            int posebni = 0;
            niz = Console.ReadLine();

            char[] nizKaraktera = niz.ToCharArray();

            for (int i = 0; i < nizKaraktera.Length; i++)
            {
                if (char.IsDigit(nizKaraktera[i]))
                {
                    znamenki++;
                }
                else if (char.IsLetter(nizKaraktera[i]))
                {
                    slova++;
                }
                else
                {
                    posebni++;
                }
            }

            Console.ReadKey();
        }
    }
}
