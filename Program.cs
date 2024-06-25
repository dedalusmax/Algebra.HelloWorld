using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        public delegate void TestDelegate(string tekst);

        public delegate void TitleDelegate(string ime, string prezime);

        static void Main(string[] args)
        {
            TestDelegate del1 = MetodaA;

            del1.Invoke("prvi puta");
            del1 = MetodaB;
            del1.Invoke("drugi puta");

            del1("treći puta");

            TitleDelegate naslovSvjedozbe = NaslovSvjedozbe;
            TitleDelegate naslovVozackeDozvole = NaslovVozackeDozvole;

            PopuniDokument(naslovSvjedozbe, "Pero", "Perić");
            PopuniDokument(naslovVozackeDozvole, "Iva", "Ivić");

            Console.ReadKey();
        }

        public static void MetodaA(string tekst)
        {
            Console.WriteLine($"Ivršavamo metodu A sa tekstom: {tekst}.");
        }

        public static void MetodaB(string poruka)
        {
            Console.WriteLine($"Ivršavamo metodu B sa porukom: {poruka}.");
        }

        private static void NaslovSvjedozbe(string ime, string prezime)
        {
            Console.WriteLine("SVJEDODŽBA");
            Console.WriteLine($"Ime i prezime polaznika: {ime} {prezime}");
        }

        private static void NaslovVozackeDozvole(string ime, string prezime)
        {
            Console.WriteLine("VOZAČKA DOZVOLA");
            Console.WriteLine($"Ime i prezime vozača: {ime} {prezime}");
        }

        // template metoda
        public static void PopuniDokument(TitleDelegate naslov, string ime, string prezime)
        {
            naslov.Invoke(ime, prezime);
            Console.WriteLine("Slika grba");
            Console.WriteLine("Mjesto i vrijeme: YYY");
            Console.WriteLine("Potpis odg. osobe: XXX");
            naslov.Invoke(ime, prezime);
        }

        private static void PopuniSvjedodzbu(string ime, string prezime)
        {
            Console.WriteLine("SVJEDODŽBA");
            Console.WriteLine("Slika grba");
            Console.WriteLine($"Ime i prezime polaznika: {ime} {prezime}");
            Console.WriteLine("Mjesto i vrijeme: YYY");
            Console.WriteLine("Potpis ravnatelja: XXX");
        }

        private static void PopuniVozackuDozvolu(string ime, string prezime)
        {
            Console.WriteLine("VOZAČKA DOZVOLA");
            Console.WriteLine("Slika grba");
            Console.WriteLine($"Ime i prezime vozača: {ime} {prezime}");
            Console.WriteLine("Mjesto i vrijeme: YYY");
            Console.WriteLine("Potpis ravnatelja: XXX");
        }
    }
}
