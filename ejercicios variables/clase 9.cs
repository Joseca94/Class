using System;
using System.Collections.Generic;

namespace clase_9
{
    class Program
    {
        static void PintarOpciones()
        {
            Console.WriteLine("opcion 1: suma ");
            Console.WriteLine("opcion 2: resta ");
            Console.WriteLine("opcion 3: division ");
            Console.WriteLine("opcion 4: multiplicacion ");
            Console.WriteLine("opcion 5: salir");
            
        }
        static int PreguntarNumero(string Texto)
        {
            Console.Write(Texto);
            return int.Parse(Console.ReadLine());
        }
        static int Division(int y, int x)
        {
            return x / y;
        }
        static int Multiplicacion(int y, int x)
        {
            return x * y;
        }
        static int resta(int y, int x)
        {
            return x - y;
        }
        static int Suma(int y, int x)
        {
            return x + y;
        }
        static void Main(string[] args)
        {

            //ARRAY DEL 1 AL 10

            //int[] numbers = new int[10];
            //for (int i = 0; i <numbers.Length ; i++)
            //{                
            //    Console.WriteLine(numbers[i] = i + 1);

            //}






            // ARRAY QUE DEVUELVE LOS NUMEROS AL CONTRARIO


            //int[] numbers = new int[3];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Escribe un numero:  ");
            //    int X = int.Parse(Console.ReadLine());
            //    numbers[i] = X;
            //}
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);

            //}








            //SUMA DE UN ARRAY QUE DIGA EL USUARIO


            //Console.WriteLine("Cuantos numeros quieres introducir? :");
            //int X = int.Parse(Console.ReadLine());
            //int[] numbers = new int[X];
            //int Total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Introduces un numero :");
            //    int y = int.Parse(Console.ReadLine());
            //    numbers[i] = X;
            //    Total += y;
            //}
            //Console.WriteLine("el total es : " + Total);






            //COPIAR ARRAYS



            //Console.WriteLine("Cuantos numeros quieres introducir? :");
            //int X = int.Parse(Console.ReadLine());
            //int[] numbers = new int[X];
            //int[] numbers2 = new int[X];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Introduces un numero :");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    numbers2[i] = numbers[i];
            //    Console.WriteLine(numbers2[i]);

            //}









            // VER SI HAY DUPLICADOS EN UN ARRAY


            //bool duplicado = false;
            //Console.WriteLine("Cuantos numeros quieres introducir? :");
            //int X = int.Parse(Console.ReadLine());
            //int[] numbers = new int[X];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Introduces un numero :");
            //    numbers[i] = int.Parse(Console.ReadLine());          

            //}
            //for (int i = 0; i < numbers.Length && !duplicado; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length && !duplicado; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            Console.WriteLine("Duplicado");
            //            duplicado = true;                      

            //        }
            //    }
            //}



            //// ORDENAR ARRAYS DE MENOR MAYOR
            //Console.WriteLine("Cuantos numeros quieres introducir? :");
            //int X = int.Parse(Console.ReadLine());
            //int[] numbers = new int[X];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Introduces un numero :");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1 ; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] > numbers[j]) 
            //        {
            //            int aux = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = aux;
            //        }

            //    }
            //    Console.WriteLine(numbers[i]);
            //}



            // LISTA DEL 1 AL 10


            //List<int> number = new List<int>();
            //for (int i = 1; i <= 9999; i++)
            //{
            //    number.Add(i + 1);
            //    Console.WriteLine(i);

            //}





            // DEVOLVER NUMEROS AL CONTRARIO CON LISTA
            //List<int> numbers = new List<int>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Escribe un numero:  ");
            //    numbers.Add(int.Parse(Console.ReadLine()));

            //}
            //for (int i = numbers.Count - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}




            //// CREAR UNA LISTA DE LA CANTIDAD QUE EL USUARIO QUIERA PEDIRLE LOS NUMEROS Y LOS ORDENA DE MENOR A MAYOR
            //List<int> numbers = new List<int>();
            //Console.WriteLine("Cuantos quieres introducir:  ");
            //int count = int.Parse(Console.ReadLine());
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine("Escribe un numero:  ");
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < numbers.Count; i++)
            //{

            //    for (int j = i + 1; j < numbers.Count; j++)
            //    {

            //        if (numbers[i] > numbers[j])
            //        {
            //            int aux = numbers[i];
            //            numbers[i] = numbers[j];
            //            numbers[j] = aux;
            //        }

            //    }
            //    Console.WriteLine(numbers[i]);
            //}









            //TABLA DE OPCIONES CON SWITCH DANDO LOS VALORES EL USUARIO
            //int z = 0;
            //do
            //{
            //    Console.WriteLine("escribe un numero: ");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("escribe otro numero: ");
            //    int y = int.Parse(Console.ReadLine());
            //    Console.WriteLine("opcion 1: suma ");
            //    Console.WriteLine("opcion 2: resta ");
            //    Console.WriteLine("opcion 3: division ");
            //    Console.WriteLine("opcion 4: multiplicacion ");
            //    Console.WriteLine("opcion 5: salir");
            //    Console.Write("escribe una opcion: ");



            //    z = int.Parse(Console.ReadLine());
            //    switch (z)
            //    {
            //        case 1:
            //            Console.WriteLine("la suma es:" + (x + y));
            //            break;
            //        case 2:
            //            Console.WriteLine("la resta es: " + (x - y));
            //            break;
            //        case 3:
            //            Console.WriteLine("la division: " + (x / y));
            //            break;
            //        case 4:
            //            Console.WriteLine("la multiplicacion es: " + (x * y));
            //            break;
            //        case 5:
            //            Console.WriteLine("adios");
            //            break;
            //        default:
            //            Console.WriteLine("error");
            //            break;
            //    }
            //} while (z != 5);









            //// TABLA CON FUNCIONES Y RETURN
            //int z = 0;
            //do
            //{
            //    int x = PreguntarNumero("escribe un numero: ");
            //    int y = PreguntarNumero("escribe otro numero: ");
            //    PintarOpciones();
            //    z = PreguntarNumero("escribe una opcion: ");
            //    switch (z)
            //    {
            //        case 1:
            //            Console.WriteLine("la suma es:" + Suma(x, y));
            //            break;
            //        case 2:
            //            Console.WriteLine("la resta es: " + resta(x, y));
            //            break;
            //        case 3:
            //            Console.WriteLine("la division: " + Division(x, y));
            //            break;
            //        case 4:
            //            Console.WriteLine("la multiplicacion es: " + Multiplicacion(x, y));
            //            break;
            //        case 5:
            //            Console.WriteLine("adios");
            //            break;
            //        default:
            //            Console.WriteLine("error");
            //            break;
            //    }
            //} while (z != 5);











        }
    }
}
