using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gradovi = { "Varaždin", "Zagreb", "Osijek", "Sisak", "Split", "Slavonski Brod" };

            // Query sintaksa upita
            var query = from grad in gradovi
                        where grad.StartsWith("S")
                        select grad;

            // Selektor sintaksa upita
            var query2 = gradovi
                .Where(grad => grad.StartsWith("S"));

            // enumerator 

            var emumerator = query.GetEnumerator();
            emumerator.MoveNext();
            var i = emumerator.Current;
            // emumerator.Reset(); // baca grešku!!

            foreach (var izbor in query)
            {
                Console.WriteLine(izbor);
            }

            var artikli = new List<Artikl>()
            {
                new Artikl(412, "Kruh", 543543543534, 0),
                new Artikl(104, "Pivo", 32432432432, 24, 2),
                new Artikl(422, "Deo", 543543543534, 24, 3),
                new Artikl(234, "Sapun", 3243243266, 24, 3),
                new Artikl(320, "Mlijeko", 3243243266, 0),
                new Artikl(204, "Sok", 455435435435, 10, 2),
                new Artikl(444, "Šampon", 2131243543534, 220, 3)
            };

            artikli.ForEach(x => Console.WriteLine(x));

            // Query sintaksa

            var upit = (from artikl in artikli
                       where artikl.StanjeNaSkladistu > 0
                       select new { artikl.Sifra, artikl.Naziv }).ToList();

            // Selector sintaksa

            var upit2 = artikli // List<Artikl>
                .Where(artikl => artikl.StanjeNaSkladistu > 0) // IEnumerable<Artikl>
                .Select(x => new { x.Barkod, x.Naziv }) // IEnumerable<anonym>
                .ToList(); // List<anonym>

            // artikli.Sort();

            Console.WriteLine();

            var sortirano = (from artikl in artikli
                             orderby artikl.Naziv
                             select artikl
                             ).ToList();

            //var sortirano = from artikl in artikli
            //                orderby artikl.Naziv
            //                select artikl;

            sortirano.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            // kompleksniji upit

            var osnovniUpit = from artikl in artikli
                            where artikl.StanjeNaSkladistu > 0 && artikl.StanjeNaSkladistu <= int.MaxValue
                            select artikl;

            var rezultirajuciUpit = osnovniUpit
                .OrderBy(x => x.Naziv)
                .Take(3);

            foreach (var stavka in rezultirajuciUpit)
                Console.WriteLine(stavka);

            var lista = from artikl in artikli
                        group artikl by artikl.Vrsta into rezultat
                        select rezultat;

            // UPDATE

            var y = from artikl in artikli
                    select artikl;

            // pozicijske metode:

            var ima = y.ElementAt(0);
            var nema = y.ElementAtOrDefault(10);
            var prvi = y.First();
            var zadnji = y.Last();

            Console.WriteLine();

            // Artikli: sifra, naziv, barkod, skladište, količina => naziv, barkod
            // proizvodi: sifra, naziv, barkod, god.proizv, okus => naziv, barkod

            var provjera = rezultirajuciUpit.SequenceEqual(osnovniUpit);

            if (y.Any(_ => _.Naziv == "Vino"))
            {
                Console.WriteLine("Zabava može početi!");
            }

            if (y.All(_ => _.StanjeNaSkladistu >= 0))
            {
                Console.WriteLine("Inventura može početi.");
            }

            if (!y.Contains(new Artikl(412, "Kruh", 00000323, 0)))
            {
                Console.WriteLine("Naručiti kruh za skladište.");
            }

            Console.WriteLine();

            // filtriranje i projekcija:

            var filtrirano = from artikl in artikli
                             where artikl.StanjeNaSkladistu > 0
                             select new { artikl.Barkod, artikl.Naziv };

            filtrirano = artikli
                .Where(artikl => artikl.StanjeNaSkladistu > 0)
                .Select(x => new { x.Barkod, x.Naziv });

            Console.WriteLine();

            // sortiranje:

            var abecedno = from a in artikli
                           orderby a.Naziv
                           select a;

            abecedno = artikli.OrderBy(_ => _.Naziv);

            var abecednoSilazno = from a in artikli
                                  orderby a.Naziv descending
                                  select a;

            abecednoSilazno = artikli.OrderByDescending(_ => _.Naziv);

            abecedno = from a in artikli 
                       orderby a.StanjeNaSkladistu, a.Naziv
                       select a;

            abecedno = artikli.OrderBy(a => a.StanjeNaSkladistu).ThenBy(a => a.Naziv);

            abecedno = from a in artikli
                       orderby a.StanjeNaSkladistu, a.Naziv descending
                       select a;

            abecedno = artikli.OrderBy(a => a.StanjeNaSkladistu).ThenByDescending(a => a.Naziv);

            Console.WriteLine();

            // grupiranje:

            var grupirano = from artikl in artikli
                            group artikl by artikl.Vrsta;                       

            foreach (var grupa in grupirano)
            {
                Console.WriteLine("Vrsta artikla: {0}", grupa.Key);

                foreach (Artikl clan in grupa)
                {
                    Console.WriteLine($"- , Šifra: { clan.Sifra }, Naziv: { clan.Naziv }");
                }
            }

            grupirano = artikli.GroupBy(a => a.Vrsta);
            grupirano = artikli.ToLookup(a => a.Vrsta);

            foreach (var grupa in grupirano)
            {
                Console.WriteLine("Vrsta artikla: {0}", grupa.Key);

                foreach (Artikl clan in grupa)
                {
                    Console.WriteLine($"- , Šifra: {clan.Sifra}, Naziv: {clan.Naziv}");
                }
            }

            Console.WriteLine();

            // spajanje (join):

            var voce = new List<string>()
            {
                "Jabuka",
                "Banana",
                "Kruška",
                "Šljiva"
            };

            var voce2 = new List<string>()
            {
                "Naranča",
                "Limun",
                "Banana",
                "Jabuka",
                "Grejp"
            };

            var z = voce.SequenceEqual(voce2);

            var podudarnosti = voce.Join(voce2,
                niz1 => niz1,
                niz2 => niz2,
                (niz1, niz2) => niz1);

            podudarnosti = from niz1 in voce
                           join niz2 in voce2
                           on niz1 equals niz2 
                           select niz1;

            foreach (var pod in podudarnosti)
                Console.WriteLine(pod);

            var proizvodi1 = new List<Artikl>()
            {
                new Artikl(412, "Kruh", 543543543534, 0),
                new Artikl(104, "Pivo", 32432432432, 24, 2),
                new Artikl(234, "Sapun", 3243243266, 24, 3),
                new Artikl(320, "Mlijeko", 3243243266, 0),
                new Artikl(444, "Šampon", 2131243543534, 220, 3)
            };

            var proizvodi2 = new List<Artikl>()
            {
                new Artikl(412, "Kruh", 432434, 10),
                new Artikl(104, "Pivo", 565465, 24, 2),
                new Artikl(422, "Deo", 54354354343443534, 24, 3),
                new Artikl(234, "Sapun", 4343, 24, 3),
                new Artikl(320, "Mlijeko", 13213, 0),
                new Artikl(204, "Sok", 455433213215435435, 10, 2)
            };

            var matches = proizvodi1.Join(proizvodi2,
                p1 => p1.Sifra,
                p2 => p2.Sifra,
                (p1, p2) => new
                {
                    p1.Naziv,
                    p2.Barkod,
                    // Naziv = p1.Naziv,
                    // Barkod = p2.Barkod,
                    Stanje1 = p1.StanjeNaSkladistu,
                    Stanje2 = p2.StanjeNaSkladistu
                });

            matches = from p1 in proizvodi1
                      join p2 in proizvodi2
                      on p1.Sifra equals p2.Sifra
                      select new
                      {
                          p1.Naziv,
                          p2.Barkod,
                          // Naziv = p1.Naziv,
                          // Barkod = p2.Barkod,
                          Stanje1 = p1.StanjeNaSkladistu,
                          Stanje2 = p2.StanjeNaSkladistu
                      };

            foreach (var match in matches)
                Console.WriteLine(match.ToString());

            var vrste = new List<VrstaArtikla>()
            {
                new VrstaArtikla() { Sifra = 1, Naziv = "Hrana" },
                new VrstaArtikla() { Sifra = 2, Naziv = "Piće" },
                new VrstaArtikla() { Sifra = 3, Naziv = "Kozmetika" },
            };

            var spoj = proizvodi2.Join(vrste,
                proizvod => proizvod.Vrsta,
                vrsta => vrsta.Sifra,
                (proizvod, vrsta) => new
                {
                    SifraProizvoda = proizvod.Sifra,
                    NazivProizvoda = proizvod.Naziv,
                    VrstaProizvoda = vrsta.Naziv,
                    proizvod.Barkod,
                    proizvod.StanjeNaSkladistu
                });

            spoj = from proizvod in proizvodi2
                   join vrsta in vrste
                   on proizvod.Vrsta equals vrsta.Sifra
                   select new
                   {
                       SifraProizvoda = proizvod.Sifra,
                       NazivProizvoda = proizvod.Naziv,
                       VrstaProizvoda = vrsta.Naziv,
                       proizvod.Barkod,
                       proizvod.StanjeNaSkladistu
                   };

            foreach (var spojnik in spoj)
                Console.WriteLine(spojnik);

            var grupe = vrste.GroupJoin(proizvodi2,
                vrsta => vrsta.Sifra,
                proizvod => proizvod.Vrsta,
                (grupa, proizvodi) => new
                {
                    VrstaArtikla = grupa,
                    Proizvodi = proizvodi
                });

            grupe = from vrsta in vrste
                    join proizvod in proizvodi2
                    on vrsta.Sifra equals proizvod.Vrsta
                    into grupa
                    select new
                    {
                        VrstaArtikla = vrsta,
                        Proizvodi = grupa
                    };

            foreach (var grupa in grupe)
            {
                Console.WriteLine("Vrsta artikla: {0}", grupa.VrstaArtikla.Naziv);

                foreach (Artikl clan in grupa.Proizvodi)
                {
                    Console.WriteLine($"- , Šifra: {clan.Sifra}, Naziv: {clan.Naziv}");
                }
            }

            Console.ReadKey();
        }
    }

    public class Artikl
    {
        public Artikl(int sifra, string naziv, long barkod, int stanje, int vrsta = 1)        
        {
            Sifra = sifra;
            Naziv = naziv;
            Barkod = barkod;
            StanjeNaSkladistu = stanje;
            Vrsta = vrsta;
        }

        public int Sifra { get; set; }

        public string Naziv { get; set; }

        public int Vrsta { get; set; }

        public long Barkod { get; set; }

        public int StanjeNaSkladistu { get; set; }

        public override string ToString()
        {
            return $"Sifra: {Sifra}, Naziv: {Naziv}, Barkod: {Barkod}, Stanje: {StanjeNaSkladistu}, Vrsta: {Vrsta}";
        }
    }

    public class VrstaArtikla
    {
        public int Sifra { get; set; }

        public string Naziv { get; set; }
    }
}
