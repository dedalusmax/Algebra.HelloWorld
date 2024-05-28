using HelloWorld.Interfaces;

namespace HelloWorld.Models
{
    internal class TekuciRacun : BankovniRacun, ISredstvoPlacanja, IBezgotovinskoPlacanje
    {
        public TekuciRacun(long broj, double stanje) : base(broj, "tekući račun", stanje)
        {

        }
    }
}
