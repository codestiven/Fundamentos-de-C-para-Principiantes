using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C__para_Principiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos enteros
            // System.Int32
            int entero = 100; // 32 bits
            // System.Int16
            short s = 140; // 16 bits
            // System.Byte
            byte b = 10; // 8 bits
            // System.Int64
            long largo = 1234124312; // 64 bits

            Console.WriteLine("int: {1}, short: {0}", s, entero);

            // Tipos flotantes
            // System.Single
            float f = 123.5f;
            // System.Double
            double d = 3.14159;
            // System.Decimal utilizado para operaciones financieras
            decimal dec = 129.99m;

            Console.WriteLine("float: {0}, dec: {1}", f, dec);

            // Otros
            // System.Char
            char c = 'E';
            // System.Boolean representa un valor verdadero o falso
            bool booleano = true;

            Console.WriteLine("char: {0}", c);
            Console.WriteLine("bool: {0}", booleano);
        }
    }
}
