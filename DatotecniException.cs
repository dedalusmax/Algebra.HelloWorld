using System;

namespace Algebra.HelloWorld
{
    internal class DatotecniException : ApplicationException
    {
        public ConsoleColor Boja { get; set; } = ConsoleColor.Magenta;

        public DatotecniException(string poruka) : base(poruka) 
        {
        }
    }
}
