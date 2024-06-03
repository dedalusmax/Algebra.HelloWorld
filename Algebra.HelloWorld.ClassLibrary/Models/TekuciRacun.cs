using Algebra.HelloWorld.ClassLibrary.Interfaces;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public class TekuciRacun : BankovniRacun, ISredstvoPlacanja, IBezgotovinskoPlacanje
    {
        public TekuciRacun(long broj, double stanje) : base(broj, "tekući račun", stanje)
        {

        }
    }
}
