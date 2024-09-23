using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C__para_Principiantes
{
    internal class CuentaBancaria
    {
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        public decimal Saldo { get; set; }



        public CuentaBancaria(string NoCuenta , String Usuario , decimal Saldo ) 
        {
            NoCuenta = NoCuenta;
            Usuario = Usuario;
            Saldo = Saldo;

        }

    }
}
