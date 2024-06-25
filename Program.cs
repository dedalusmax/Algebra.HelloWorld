using HelloWorld;
using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obrada = new ObradaPodataka();

            obrada.ProcesZavrsen += ProcesObradeZavrsen;

            obrada.PokreniProces();

            // tralala

            Console.ReadKey();
        }

        private static bool ProcesObradeZavrsen()
        {
            Console.WriteLine("Dočekali kraj procesa.");
            return true;
        }
    }

    internal class Program2
    {
        public delegate void TestDelegate(string tekst);

        public delegate void TitleDelegate(string ime, string prezime);

        public delegate Vrijeme PrognozaDelegate(string geolokacija);

        public enum Vrijeme
        {
            Suncano,
            Kisa,
            Snijeg
        }

        static void Glavna()
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

            del1 = MetodaA;
            TestDelegate del2 = MetodaB;

            TestDelegate del = del1 + del2;
            del("rezultat");

            TestDelegate del3 = (string tekst) => Console.WriteLine($"Ivršavamo metodu C sa tekstom: {tekst}."); // MetodaC
            del3("tekst");

            del += del3;
            del("rezultat");

            del -= del1;

            PrognozaDelegate servis = PozoviServis;
            IspisiPrognozuZaNajblizeGradove(servis, "0.2323,3232.3");

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

        private static Vrijeme PozoviServis(string geolokacija)
        {
            return Vrijeme.Suncano;
        }

        private static void IspisiPrognozuZaNajblizeGradove(PrognozaDelegate servis, string geolokacija)
        {
            var mojaLokacija = servis.Invoke(geolokacija);
            Console.WriteLine(mojaLokacija.ToString());

            // najbliže lokacije
            Console.WriteLine(servis.Invoke("1111").ToString());
            Console.WriteLine(servis.Invoke("222").ToString());
            Console.WriteLine(servis.Invoke("333").ToString());
        }
    }
}
