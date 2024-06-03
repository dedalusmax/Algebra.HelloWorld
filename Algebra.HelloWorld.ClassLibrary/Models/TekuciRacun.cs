using Algebra.HelloWorld.ClassLibrary.Enumerations;
using Algebra.HelloWorld.ClassLibrary.Interfaces;

namespace Algebra.HelloWorld.ClassLibrary.Models
{
    public class TekuciRacun : BankovniRacun, ISredstvoPlacanja, IBezgotovinskoPlacanje
    {
        public TekuciRacun(long broj, double stanje) : base(broj, VrstaRacuna.TekuciRacun, stanje)
        {

        }
    }
}
