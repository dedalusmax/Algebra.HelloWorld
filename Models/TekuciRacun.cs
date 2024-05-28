namespace HelloWorld.Models
{
    internal class TekuciRacun : BankovniRacun
    {
        public TekuciRacun(long broj, double stanje) : base(broj, "tekući račun", stanje)
        {

        }
    }
}
