namespace HelloWorld
{
    internal class Zaposlenik : Osoba
    {
        // ime
        // prezime
        public int GodineRadnogStaza { get; set; }

        public Zaposlenik()
        {
            this.IzracunajGodine();
        }

        public override void UnesiGodineIskustva(int brojGodina)
        {
            GodineIskustva = brojGodina + 5;
        }
    }
}
