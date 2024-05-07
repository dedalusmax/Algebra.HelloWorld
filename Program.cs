using System;
using System.Linq;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Ovo je jedna rečenica";
            string[] tekst = recenica.Split(' ');

            if (tekst.Length > 0)
            {
                Console.WriteLine(tekst[1]);
                tekst[0] = "To";
                Console.WriteLine(tekst.ToString());
            }

            // string[] ljubimci;
            // string[] ljubimci = new string[2];
            //string[] ljubimci = new string[] { "pas", "mačka", "ribica" };
            string[] ljubimci = { "pas", "mačka", "ribica" };

            ljubimci[2] = "hrčak";

            short[] ocjene = { 1, -2, 2, -3, 3, -4, 4, -5, 5 };

            // dvodimenzionalni niz 

            int[,] matrica = new int[10, 10];
            matrica[1, 4] = 10;

            Console.ReadKey();
        }
    }
}
