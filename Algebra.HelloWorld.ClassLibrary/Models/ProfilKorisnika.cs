using Algebra.HelloWorld.ClassLibrary.Interfaces;
using System;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public class ProfilKorisnika : IInfo
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
