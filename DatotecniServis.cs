using System.IO;

namespace Algebra.HelloWorld
{
    internal static class DatotecniServis
    {
        /// <summary>
        /// Metoda za rad s tekstualnom datotekom.
        /// </summary>
        /// <param name="naziv">Naziv datoteke</param>
        /// <returns>Sadržaj u tekstu</returns>
        /// <exception cref="DatotecniException"></exception>
        internal static string OtvoriDatoteku(string naziv)
        {
            if (!File.Exists(naziv))
            {
                throw new DatotecniException(string.Format("Ne postoji takva datoteka na disku: {0}", naziv));
            }

            using (var reader = File.OpenText(naziv))
            {
                var tekst = reader.ReadToEnd();
                return tekst;
            }
        }
    }
}
