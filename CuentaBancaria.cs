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


        //backing field
        private decimal _Saldo;

        // propiedad completa
        public decimal Saldo 
        { 
          get { return _Saldo; }
            set
            {    /*
             if (value <= 0) 
                {
                    _Saldo = 0; 
                } else
                {
                    _Saldo = value;
                }
                 */

                _Saldo = value < 0 ? 0 : value;
            }
        
        }  


        #region CuentaBancaria
        public CuentaBancaria(string NoCuenta , String Usuario ) 
        {
            NoCuenta = NoCuenta;
            Usuario = Usuario;
            Saldo = Saldo;


        }
        #endregion

        public void Retirar(Decimal cantidad) 
        {
           Saldo -= cantidad;
        
        }

    }
}
