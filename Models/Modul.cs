namespace HelloWorld.Models
{
    internal class Modul
    {
        public int RedniBroj { get; set; }

        public string Naziv { get; set; }

        // kolokvij|parcijalni ispit...

        public Modul(int redniBroj, string naziv)
        {
            RedniBroj = redniBroj;
            Naziv = naziv;
        }
    }
}
