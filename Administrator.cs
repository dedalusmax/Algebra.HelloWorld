using System;

namespace HelloWorld
{
    internal sealed class Administrator : Osoba
    {
        // ime 
        // prezime

        public Administrator()
        {
        }

        public void ZadajPravaPristupa()
        {

        }

        public override void UnesiRadnoVrijeme(DateTime vrijemeOd, DateTime vrijemeDo)
        {
            Prijavi("pero", "21312");
            // moja logika za unos radnog vremena za drugog zaposlenika

            // base.UnesiRadnoVrijeme(vrijemeOd, vrijemeDo);
        }

        public override void UnesiGodineIskustva(int brojGodina)
        {
            GodineIskustva = brojGodina;
        }
    }
}
