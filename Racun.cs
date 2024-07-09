using System;

namespace HelloWorld
{
    public class Racun : IEquatable<Racun>, IComparable<Racun>
    {
        public int Sifra { get; set; }

        public string Naziv { get; set; }

        public double Stanje { get; set; }

        public void Uplata(double iznos)
        {
            if (iznos > 0)
            {
                Stanje += iznos;
            }
        }

        public void Isplata(double iznos)
        {
            if (iznos > 0)
            {
                Stanje -= iznos;
            }
        }

        public bool Equals(Racun other)
        {
            if (other == null) return false;

            return (this.Sifra == other.Sifra && this.Naziv == other.Naziv && this.Stanje == other.Stanje);
        }

        public int CompareTo(Racun other)
        {
            if (this.Equals(other)) return 0;

            if (other == null) return 1;

            //return -1;

            return (this.Sifra > other.Sifra) ? 1 : -1;
        }

        public static bool operator ==(Racun racun1, Racun racun2)
        {
            if (((object)racun1) == null || ((object)racun2) == null)
                return Equals(racun1, racun2);

            return racun1.Equals(racun2);
        }

        public static bool operator !=(Racun racun1, Racun racun2)
        {
            if (((object)racun1) == null || ((object)racun2) == null)
                return !Equals(racun1, racun2);

            return !racun1.Equals(racun2);
        }
    }
}
