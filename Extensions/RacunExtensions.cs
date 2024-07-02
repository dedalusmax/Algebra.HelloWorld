namespace HelloWorld.Extensions
{
    public static class RacunExtensions
    {
        public static void Isplata(this Racun racun, double iznos)
        {
            racun.Stanje -= iznos;
        }
    }
}
