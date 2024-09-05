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
            //Ciclo For
            Console.WriteLine("usando el ciclo For");
            for (int i = 0; i < 50; i++) 
            {
             Console.WriteLine("Valor de el contado i : {0}" , i);
            }
            //Ciclo While
            Console.WriteLine("\n usando el ciclo while");
            int n = 0;
            while (n < 50)
            {
                Console.WriteLine("Valor de el contador i : {0}" , n);
                n++;
            }
            //Ciclo Do - while
            int c = 0;
            Console.WriteLine("\n usando el ciclo Do - while");
            do
            {
                Console.WriteLine("Valor de el contador i : {0}", c);
                c++;
            }while (c < 50);
        }
    }
}
