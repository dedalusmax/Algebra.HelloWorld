using HelloWorld.Contracts;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Algebra.HelloWorld2
{
    internal class Program
    {
        private const string FILE_PATH = "C:\\Projects\\Algebra\\Test2\\example.dat";

        static void Main(string[] args)
        {
            Console.WriteLine("Spreman za primanje podataka...");
            Console.ReadKey();

            // strana primatelja:

            var racun = PrimiRacun(FILE_PATH);
            Console.WriteLine("Primljeno!");

            racun.Uplata(30.00);

            Console.WriteLine(racun);
            Console.ReadKey();
        }

        private static Racun PrimiRacun(string filePath)
        {
            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var rezultat = (Racun)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return rezultat;
        }
    }
}
