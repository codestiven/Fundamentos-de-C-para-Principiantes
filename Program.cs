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
            Console.WriteLine("\n usando el break");
            for (int i = 0; i < 50; i++)
            {
                if (i == 20)
                {
                    break;
                }
                Console.WriteLine("Valor de el contado i : {0}", i);
            }
            Console.WriteLine("\n usando el Continue");
            for (int i = 0; i < 50; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                if (i == 20)
                {
                    break;
                }
                Console.WriteLine("Valor de el contado i : {0}", i);
            }
        }
    }
}
