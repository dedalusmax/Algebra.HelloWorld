using HelloWorld.Contracts;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        private const string FILE_PATH = "C:\\Projects\\Algebra\\Test\\example.dat";

        static void Main(string[] args)
        {
            // strana pošiljatelja:

            var racun = new Racun
            {
                Sifra = 12345,
                Naziv = "Tekući račun Pere Perića",
            };

            racun.Uplata(50.00);

            Console.WriteLine("Spreman za slanje podataka...");
            Console.ReadKey();

            PosaljiRacun(FILE_PATH, racun);
            Console.WriteLine("Poslano!");

            Console.WriteLine("Čekam prijem s druge strane...");
            Console.ReadKey();
        }

        private static void PosaljiRacun(string filePath, Racun racun)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, racun);
            fileStream.Close();
        }
    }
}
