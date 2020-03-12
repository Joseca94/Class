using System;
using System.Collections.Generic;
using System.Text;

namespace Clase10
{
    public struct transaccion
    {
        public int cantidad;
        public string concepto;

        public transaccion(int cantidad, string concepto)
        {
            this.cantidad = cantidad;
            this.concepto = concepto;
        }
        public float GetCantidad()
        {
            return this.cantidad;
        }
        public string GetConcepto()
        {
            return this.concepto;
        }
        public override string ToString()
        {
            string info = "";
            info += "cantidad" + cantidad;
            info += "\n";
            info += "concepto" + concepto;
            return info;            
        }
        
    } 
}
      



