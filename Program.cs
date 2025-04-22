using System;
using System.Linq;

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

            /* 
            TURA 2:
            1.	Kopirajte jedan niz u drugi niz, uz unos pojedinih riječi, sastavljanje rečenice
            2.	Pronađite broj pojavljivanja određenog niza u nizu riječi
            3.	Provjerite korisničko ime i lozinku, za unos imate 3 pokušaja
            4.	Ispiši polaznike seminara (koliko nas ima), od broja 1 do 10- evidencija polaznika/seminaru
            5.	Prosjek ocjena za uneseni broj predmeta
            */

            // 1

            //zadatak 1

            Console.WriteLine("Zadatak 1");
            string[] niz1 = new string[3] { "Ana", "voli", "Milovana" };
            string[] niz2 = new string[3];
            string recenica = "";

            //Zalijepo indeks kao unos pojedine riječi :D
            for (int i = 0; i < niz1.Length; i++)
            {
                niz2[i] = niz1[i] + i;

            }

            //sastavljanje rečenice od novog niza i ispis 
            for (int j = 0; j < niz2.Length; j++)
            {
                if (String.IsNullOrEmpty(recenica))
                {
                    recenica = niz2[j];
                }
                else
                {
                    recenica += " " + niz2[j];
                }

            }

            Console.WriteLine(recenica);


            // 2

            string[] arr = { "how", "what", "why", "when", "who" };
            int count = 0;


            string unos = Console.ReadLine();
            foreach (string s in arr)
            {
                if (s.Contains(unos))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            // 3 

            const string userName = "admin", password = "1234";
            bool corr = false;
            for (short i = 0; i < 3; i++)
            {
                Console.Write("Please enter username: ");
                string inputName = Console.ReadLine();
                Console.Write("Please enter password: ");
                string inputPw = Console.ReadLine();
                //if (inputName.Equals("admin") && inputPw.Equals("1234"))
                if (inputName.Equals(userName) && inputPw.Equals(password))
                //if (inputName == userName && inputPw == password)
                {
                    corr = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password.\n");
                }
            }
            if (corr)
            {
                Console.WriteLine("Logged in.\nTASK 3 DONE\n");
            }
            else
            {
                Console.WriteLine("No more attempts allowed.\nTASK 3 DONE\n");
            }

            // Zadatak 4:

            for (byte i = 1; i <= 17; i++)
            {
                Console.WriteLine($"Polaznik {i} ima sljedeću evidenciju dolazaka: ");
                for (byte j = 1; j <= 10; j++)
                {
                    var rand = new Random(); //generira slučajni broj
                    Console.WriteLine((rand.Next(0, 50) % 2) == 1 ? "Došao" : "Nije");
                }
            }

            // 5

            Console.Write("Broj predmeta: ");
            byte brojPredmeta = Convert.ToByte(Console.ReadLine());

            byte[] predmeti = new byte[brojPredmeta];
            for (int i = 0; i < brojPredmeta; i++)
            {
                Console.Write($"Ocjena za predmet {i + 1}: ");
                predmeti[i] = Convert.ToByte(Console.ReadLine());
            }

            float prosjek = 0;
            for (int i = 0; i < brojPredmeta; i++)
            {
                prosjek += predmeti[i];
            }
            prosjek /= brojPredmeta;
            //prosjek = prosjek / brojPredmeta;

            Console.Write($"Prosjek: {prosjek:F2}");
            Console.ReadKey();
        }
    }
}
