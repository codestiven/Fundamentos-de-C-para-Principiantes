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
            //crear un objeto de tipo rectangulo
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Altura = 5;
            rectangulo.Base = 5;

            Console.WriteLine(rectangulo.CalcularArea());

            // sintaxi de inicializacion 
            Rectangulo rectangulo1 = new Rectangulo { Altura=3 ,Base = 8};
            Console.WriteLine(rectangulo1.CalcularArea());



        }
    }
}
