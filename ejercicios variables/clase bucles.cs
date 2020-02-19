using System;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Escribe un numero: ");
            //int repeticiones = int.Parse(Console.ReadLine());
            //int contador = 0;
            //while (contador < repeticiones)
            //{
            //    Console.WriteLine(contador);
            //    contador = contador + 1;
            //}




            //Console.Write("Escribe un numero: ");
            //int tabla = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero: ");
            //int Numero = int.Parse(Console.ReadLine());
            //int contador = 0;
            //while (contador <= Numero)
            //{
            //    Console.WriteLine(tabla + "x" + contador + "=" + (tabla * contador));
            //    contador += 1;




            //}
            //Console.Write("Escribe un numero: ");
            //int repeticiones = int.Parse(Console.ReadLine());
            //int contador = 0;
            //do
            //{
            //    Console.WriteLine(contador);
            //    contador = contador + 1;
            //}
            //while (contador < repeticiones);



            //Console.Write("Escribe un numero: ");
            //int repeticiones = int.Parse(Console.ReadLine());           
            //for (int i = 0; i < repeticiones; i++)
            //{
            //    Console.WriteLine(i);
            //}



            Console.Write("Escribe un numero: ");
            int tabla = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe otro numero: ");
            int Numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numero; i++)

            {
                Console.WriteLine(tabla + "x" + i + "=" + (tabla * i));
                                                          
            }
        }
    }
}
