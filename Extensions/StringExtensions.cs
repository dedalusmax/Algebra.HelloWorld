using System;

namespace HelloWorld.Extensions
{
    public static class StringExtensions
    {
        public static void Print(this string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
