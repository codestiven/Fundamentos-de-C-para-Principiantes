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
            int a = 30;
            int b = 11;
            // operador aritmeticos
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);   
            Console.WriteLine(a % b); // modulo

            //operdores unitarios
            a++; // a = a + 1
            a--; // a = a - 1
            // operadores de comparacion
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
    }
}
