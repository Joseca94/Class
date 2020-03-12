using System;
using System.Collections.Generic;
using Clase10;

namespace clase_9
{
    class Program
    {
        static void Main (string[] args)
        {
            transaccion transaccion = new transaccion(20, "por que si");
            cuentas cuentas = new cuentas("nacho");
            cuentas.AñadirTransaccion(transaccion);
            cuentas.AñadirTransaccion(transaccion);
            cuentas.AñadirTransaccion(transaccion);
            cuentas.MontrarTransacciones();




        }
    }
   
    
}
