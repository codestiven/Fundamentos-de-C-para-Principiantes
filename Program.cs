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
            Console.WriteLine("reto tabla de multiplicar");
            int multiplicando = 0;
            int multiplicador = 0;
            Console.Write("hasta donde deseas tu tabla : ");
            int count = int.Parse(Console.ReadLine());
            while (multiplicador <= count)
            {
                Console.WriteLine("\ntabla de el " + multiplicador + "\n");
                for (multiplicando = 0; multiplicando <= 12; multiplicando++)
                {
                    Console.WriteLine("{0} + {1} = {2}" , multiplicando , multiplicador , multiplicando * multiplicador);

                }
                multiplicador++;
            



            }
        }
    }
}
