using System;
using System.Collections.Generic;
using System.Text;

namespace Clase10
{
    class cuentas
    {
        public string nombrePropietario;
        public List<transaccion> transacciones;

        public cuentas(string nombrePropietario)
        {
            this.nombrePropietario = nombrePropietario;
            transacciones = new List<transaccion>();
        }
        public void AñadirTransaccion(transaccion transaccion)
        {
            transacciones.Add(transaccion);
        }
        public void MontrarTransacciones()
        {
            Console.WriteLine("Transacciones");
            for (int i = 0; i < transacciones.Count; i++)
            {
                Console.WriteLine("--------------");
                Console.WriteLine(transacciones[i].ToString());
                Console.WriteLine("--------------");
            }

        }
    
    }
}
