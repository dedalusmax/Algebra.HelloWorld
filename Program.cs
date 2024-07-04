using HelloWorld;
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

            // PosaljiRacun(FILE_PATH, racun);

            var podatak = SpremiRacunUMemoriju(racun);

            // strana primatelja:

            // Racun rezultat = PrimiRacun(FILE_PATH);

            Racun rezultat = ProcitajRacunIzMemorije(podatak);

            rezultat.Uplata(30.00);

            Console.WriteLine(racun);
        }

        private static Racun PrimiRacun(string filePath)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //var rezultat = binaryFormatter.Deserialize(fileStream) as Racun;
            var rezultat = (Racun)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return rezultat;
        }

        private static void PosaljiRacun(string filePath, Racun racun)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, racun);
            fileStream.Close();
        }

        private static byte[] SpremiRacunUMemoriju(Racun racun)
        {
            var binaryFormatter = new BinaryFormatter();
            var memoryStream = new MemoryStream();
            binaryFormatter.Serialize(memoryStream, racun);
            memoryStream.Flush();
            return memoryStream.ToArray();
        }

        private static Racun ProcitajRacunIzMemorije(byte[] podaci)
        {
            var binaryFormatter = new BinaryFormatter();
            var memoryStream = new MemoryStream(podaci);
            var rezultat = (Racun)binaryFormatter.Deserialize(memoryStream);
            memoryStream.Close();
            return rezultat;
        }

    }
}
