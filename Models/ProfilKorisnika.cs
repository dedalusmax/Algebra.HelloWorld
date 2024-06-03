using HelloWorld.Interfaces;
using System;

namespace HelloWorld.Models
{
    internal class ProfilKorisnika : IInfo
    {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public void Info()
        {
            Console.WriteLine("Korisnički profil:");
            Console.WriteLine($"Id: {Id}, Ime: {Ime}, Prezime: {Prezime}.");
        }
    }
}
