using Algebra.HelloWorld.ClassLibrary.Interfaces;
using Algebra.HelloWorld.ClassLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        /// <summary>
        /// Ovo je početna točka izvršavanja programa.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var racun = new TekuciRacun(12321312, 50.00);
            racun.Info();
            Console.ReadLine();

            racun.Uplati(500.00);
            racun.Info();
            Console.ReadLine();

            racun.Isplati(1200.00);
            racun.Info();
            Console.ReadLine();

            var ziroRacun = new ZiroRacun(23232, 0.00);
            ziroRacun.Info();
            Console.ReadLine();

            var kartica = new KreditnaKartica("2222 3433 3334 3333", 150.00);
            kartica.Info();

            // skupiti sve tj ama baš sve u listu (i što ne treba) :(
            ArrayList svastara = new ArrayList();
            svastara.Add(racun);
            svastara.Add(kartica);  
            svastara.Add(ziroRacun);
            svastara.Add("smeće");
            svastara.Add(-232);

            // skupimo sve što pripada, tj. nasljeđuje od bazne klase
            List<BankovniRacun> racuni = new List<BankovniRacun>();
            racuni.Add(racun);
            racuni.Add(ziroRacun);
            //racuni.Add(kartica);

            Console.Clear();

            var dzep = new Novcanik();
            dzep.Uplati(30.00);

            //IspisiPodatke(racun);
            //IspisiPodatke(ziroRacun);
            //IspisiPodatke(kartica);
            //IspisiPodatke(dzep);

            Console.WriteLine("Kućne financije");
            Console.WriteLine("===============");

            var kucneFinancije = new List<ISredstvoPlacanja>() { racun, ziroRacun, kartica, dzep };
            foreach (var kucni in kucneFinancije)
            {
                kucni.Uplati(100);
                kucni.Info();
            }

            Console.WriteLine("m-Bankarstvo");
            Console.WriteLine("===============");

            var mBankarstvo = new List<IBezgotovinskoPlacanje>() { racun, ziroRacun, kartica };
            foreach (var mRacun in mBankarstvo)
            {
                mRacun.Info();
            }

            var profil = new ProfilKorisnika() 
            { 
                Id = 1,
                Ime = "Pero",
                Prezime = "Perić"
            };

            var informacije = new List<IInfo>() { racun, ziroRacun, kartica, dzep, profil };
            foreach (var info in informacije)
            {
                info.Info();
            }

            Console.ReadKey();
        }

        private static void IspisiPodatke(ISredstvoPlacanja racun)
        {
            racun.Info();
        }

    }
}
