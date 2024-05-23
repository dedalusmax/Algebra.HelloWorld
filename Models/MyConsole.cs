using System;

namespace HelloWorld.Models
{
    public static class MyConsole
    {
        public static void WriteLine(string tekst)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }
    }
}
