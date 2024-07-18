using System;
using System.Collections.Generic;
using System.Linq;

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

            var e = query.GetEnumerator().Current;
            query.GetEnumerator().MoveNext();

            //foreach (var izbor in query)
            //{
            //    Console.WriteLine(izbor);
            //}

            var artikli = new List<Artikl>()
            {
                new Artikl(104, "Pivo", 32432432432, 24, "Piće"),
                new Artikl(204, "Sok", 455435435435, 10, "Piće"),
                new Artikl(412, "Kruh", 543543543534, 0),
                new Artikl(320, "Mlijeko", 3243243266, 0),
                new Artikl(422, "Deo", 543543543534, 45, "Kozmetika"),
                new Artikl(234, "Sapun", 3243243266, 220, "Kozmetika"),
                new Artikl(444, "Šampon", 2131243543534, 220, "Kozmetika")
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

            var nema = y.ElementAtOrDefault(10);

            var provjera = rezultirajuciUpit.SequenceEqual(osnovniUpit);

            if (y.Any(_ => _.Naziv == "Vino"))
            {

            }

            if (y.All(_ => _.Naziv == "Vino"))
            {

            }


            Console.ReadKey();
        }
    }

    public class Artikl
    {
        public Artikl(int sifra, string naziv, long barkod, int stanje, string vrsta = "Hrana")        
        {
            Sifra = sifra;
            Naziv = naziv;
            Barkod = barkod;
            StanjeNaSkladistu = stanje;
        }

        public int Sifra { get; set; }

        public string Naziv { get; set; }

        public string Vrsta { get; set; }

        public long Barkod { get; set; }

        public int StanjeNaSkladistu { get; set; }

        public override string ToString()
        {
            return $"Sifra: {Sifra}, Naziv: {Naziv}, Barkod: {Barkod}, Stanje: {StanjeNaSkladistu}";
        }
    }
}
