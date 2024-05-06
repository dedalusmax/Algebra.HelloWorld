using System;

namespace Algebra.HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte ocjene = 5;
            //byte ocjena2 = -4;

            //short ocjene3 = -255;
            //ushort ocjene4 = -255;

            //int rgb = 0x343433;
            //byte rgb2 = 0b_0010_1111;

            bool programiranjeJeZabavno = true;
            bool vaniPadaKisa = false;

            Console.WriteLine(programiranjeJeZabavno && vaniPadaKisa);
            Console.WriteLine(programiranjeJeZabavno || vaniPadaKisa);
            Console.WriteLine(vaniPadaKisa);
            Console.WriteLine(!vaniPadaKisa);

            int a = 10;
            int b = 20;

            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Console.WriteLine(a < b && b == 0);

            string ime = "Pero";

            Console.WriteLine(ime == "Mato");
            Console.WriteLine(ime != "Ivica");

            string pwd = "";
            Console.WriteLine(ime == "pero@algebra.hr" && pwd == "pero123");

            Console.ReadKey();
        }
    }
}
