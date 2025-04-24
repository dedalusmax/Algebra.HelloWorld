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

            // Zadatak 1

            int x = 1;
            while (x < 10)
            {
                x++;
            }

            // Zadatak 2

            int y = 10;
            while (y > 0)
            {
                y--;
            }

            // Zadatak 3a

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

            // Zadatak 3b

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

            // Zadatak 4

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

            // Zadatak 5

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

            // Zadatak 1

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

            // Zadatak 2

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

            // Zadatak 3

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

            // Zadatak 4

            for (byte i = 1; i <= 17; i++)
            {
                Console.WriteLine($"Polaznik {i} ima sljedeću evidenciju dolazaka: ");
                for (byte j = 1; j <= 10; j++)
                {
                    var rand = new Random(); //generira slučajni broj
                    Console.WriteLine((rand.Next(0, 50) % 2) == 1 ? "Došao" : "Nije");
                }
            }

            // Zadatak 5

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

            /*
            TURA 3:
            1.	Petlja koja uspoređuje nizove životinja
            2.	Prikažite obrazac poput piramide s brojevima uvećanima za 1
            3.	Poredaj unešeni niz u rastućem redoslijedu
            4.	Ispis neparnih brojeva koji su veći od 1, a manji od 20
            5.	Ispis brojeva iz intervala [1, 300] koji su djeljivi s 5
             */

            // Zadatak 1

            Console.WriteLine("1.Zadatak");
            string[] zivotinje1 = new string[5] { "pas", "macka", "zec", "lisica", "vuk" };
            string[] zivotinje2 = new string[5] { "lav", "riba", "zec", "tigar", "zmija" };

            foreach (string z in zivotinje1)
            {

                foreach (string z2 in zivotinje2)
                {
                    if (z.Equals(z2))
                    {
                        Console.WriteLine($"{z} se nalazi u oba niza.");
                    }
                }

            }

            // Zadatak 2

            int arrs = 5;
            int n = 1;

            for (int i = 1; i <= arrs; i++)
            {

                for (int space = 0; space <= arrs - i; space++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + " ");
                    n++;
                }

                Console.WriteLine();
            }

            // Zadatak 4

            var brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int neparni = 0;


            for (int i = 0; i < brojevi.Length; i++)
            {

                if (brojevi[i] % 2 == 1)
                {
                    Console.WriteLine($"Broj {brojevi[i]} je neparan ");
                    neparni++;

                }

                else
                {
                    Console.WriteLine($"Broj {brojevi[i]} nije neparan ");
                    continue;
                }

            }
            Console.WriteLine($"Ukupno neparnih brojeva {neparni}");
            Console.ReadKey();
        }
    }
}

