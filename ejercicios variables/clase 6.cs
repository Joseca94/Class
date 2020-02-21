using System;
using System.Collections.Generic;

namespace Clase_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // IMPORTANTE RECORDAR LAS VARIABLES AUXILIARES
            //Console.WriteLine("introduce un numero:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("introduce otro numero:");
            //int y = int.Parse(Console.ReadLine());
            //int x1 = y;
            // y = x;
            // x = x1;
            //Console.WriteLine("ahora este es el primero: " + x);
            //Console.WriteLine(" este es el segundo:  " + y);







            //// EJERCICIO DE ORDENACION SIN TERMINAR 
            //Console.WriteLine("cuantos numeros quieras ordenar: ");
            //int numberscount = int.Parse(Console.ReadLine());
            //int[] numbers = new int[numberscount];
            //int counter = 0

            //Console.WriteLine("introduce tus numeros: ");
            //for (int x = 0; x < numbers.Length; x++)
            //{
            //    Console.WriteLine("numero" + (x + 1) + ":");
            //    numbers[x] = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < numberscount; i++)
            //    {
            //        for (int j = i + 1; j < numbers.Length; j++)
            //        {
            //            if (numbers[j] < numbers[i])
            //            {
            //                int aux = numbers[i];
            //                numbers[i] = numbers[j];
            //                numbers[j] = aux;

            //            }
            //        }
            //        Console.WriteLine(numbers[i]);
            //    }

            //}








            // ESCALERA DE ASTERISCOS
            //Console.WriteLine("cuantos * quieres ver : ");
            //int x = int.Parse(Console.ReadLine());           
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {

            //        Console.Write("* ");                   
            //    }
            //    Console.WriteLine();


            //}









            //DETECTAR DUPLICADOS
            //int[] numbers = new int[] { 3, 1, 3 };
            //bool repeated = false;
            //for (int i = 0; i < numbers.Length && !repeated; i++)
            //{

            //    for (int j = i + 1; j < numbers.Length && !repeated; j++)
            //    {
            //        if (numbers[i] == numbers[j]) ;
            //        {
            //            Console.WriteLine("estan duplicados");
            //            repeated = true;

            //        }



            //    }

            //}
            //if (!repeated)
            //{
            //    Console.WriteLine("No hay duplicados");
            //}









            ////MAYOR Y MENOR
            //Console.WriteLine("cuantos numeros quieres comparar: ");
            //int x = int.Parse(Console.ReadLine());
            //int[] numbers = new int[x] ;
            //int counter = 0;
            //int mayor = int.MinValue;
            //int menor = int.MaxValue;


            //while (counter<x)
            //{
            //    Console.Write("introduce un numero: ");
            //    int y = int.Parse(Console.ReadLine());
            //    numbers[counter] = y;
            //    counter++;
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] > mayor)
            //    {
            //        mayor = numbers[+i];
            //    }
            //    if (numbers[i] < menor)
            //    {
            //        menor = numbers[i];
            //    }

            //}
            //Console.WriteLine("mayor: " + mayor + "menor: " + menor);







            // IMPORTANTE SABER QUE SON LAS COLUMNAS Y LAS FILAS
            //Console.WriteLine("PATRON 1: ");
            //Console.Write("filas: ");
            //int y = int.Parse(Console.ReadLine());
            //int number = 1;
            //for (int i = 0; i < y; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {

            //        Console.Write(number++ + " ");
            //    }
            //    Console.WriteLine();                                                       

            //Console.WriteLine("PATRON 2: ");
            //Console.Write("filas: ");
            //int y = int.Parse(Console.ReadLine());
            //int number = 1;
            //for (int i = 0; i < y ; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //       Console.Write(number + " ");                 
            //    }
            //    number++;
            //    Console.WriteLine();
            //}                                       

            //Console.WriteLine("PATRON 3: ");
            //Console.Write("filas: ");
            //int y = int.Parse(Console.ReadLine());
            //int number = 1;
            //for (int i = 0; i < y; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(number +  " ");
            //        number++;
            //    }
            //    number = 1;
            //    Console.WriteLine();
            //}








            //// EJERCICIO DE ORDENACION SIN TERMINAR I FILAS J COLUMNAS
            //Console.WriteLine("Magnitud: ");
            //int Magnitud = int.Parse(Console.ReadLine());
            //int[,] matriz = new int[Magnitud, Magnitud];
            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            matriz[i, j] = 1;
            //        }
            //        Console.Write(matriz[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}








            // USAR using System.Collections.Generic; AL PRINCIPIO PARA PODER USAR LISTAS
            //List<int> numbers = new List<int>();
            //List<float> numbers1 = new List<float>();
            //List<char> letras = new List<char>();
            //List<string> frase = new List<string>();
            //List<double> numbersdouble = new List<double>();
            //List<bool> booleans = new List<bool>();
            //numbers.Add(1);
            //numbers.Add(5000);
            //numbers.Add(45);
            //numbers.Add(1000);
            //numbers.Remove(1000);
            //numbers.RemoveAt(0);
            // por cada variable en esta lista hago tal
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);

            //}






            ////PAR IMPAR CON FOREACH
            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(1);
            //numbers.Add(2);
            //foreach (var number in numbers)
            //{
            //    if( number % 2 == 0)
            //    {
            //        Console.WriteLine("Es par");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Es impar");
            //    }

            //}




            //string nombre = "Jose carlos";
            //foreach (var letter in nombre)
            //{
            //    Console.WriteLine(letter);
            //}





        }
    }
}
