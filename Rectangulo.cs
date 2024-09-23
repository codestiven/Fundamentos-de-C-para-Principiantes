using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C__para_Principiantes
{
    internal class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea() { 
        return Base * Altura;
        }
    }
}
