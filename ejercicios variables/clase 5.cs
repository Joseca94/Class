using System;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Escribe un numero");
            //int repeticiones = int.Parse(Console.ReadLine());
            //int contador = 0;
            //while ( contador < repeticiones)
            //{
            //    Console.WriteLine(contador);
            //    contador = contador + 1;
            //}
            //Console.WriteLine("Escribe un numero");
            //int repeticiones1 = int.Parse(Console.ReadLine());
            //int contador1 = 0;
            //do
            //{
            //    Console.WriteLine(contador1);
            //    contador1 = contador1 + 1;

            //} while (contador1 < repeticiones1);





            //Console.WriteLine("Escribe un numero");
            //int repeticiones2 = int.Parse(Console.ReadLine());           
            //for (int i = 0; i < repeticiones2; i++)
            //{
            //    Console.WriteLine(i);





            //}
            //Console.WriteLine("escribe un numero");
            //int repeticiones = int.Parse(Console.ReadLine());
            //int sumat = 0;
            //int counter = 1;
            //while (counter <= repeticiones)
            //{
            //    sumat = sumat + counter;
            //    counter++;

            //}
            //Console.WriteLine(sumat);





            // puto for IMPORTANTE LA COMA
            //Console.WriteLine("escribe un numero");
            //int repeticiones = int.Parse(Console.ReadLine());
            //int counter ;
            //int sumat ;
            //for (counter = 1, sumat = 0; counter <= repeticiones; counter++)
            //{
            //    sumat = sumat + counter;              

            //}
            //Console.WriteLine(sumat);





            //  FOR (inicializacion , condicion , iteracion)
            //Console.WriteLine("Escribe un numero: ");
            //int repetitions = int.Parse(Console.ReadLine());
            //for (int counter = repetitions; counter >= 0; counter--)
            //{
            //    Console.WriteLine(counter);
            //}


            //  METER TODO DENTRO DEL DO Y SACAR LA VARIABLE, LA VARIABLE TIENE UNA VIDA HASTA QUE SE CIARRA EL CORCHETE
            //int y = 0;
            //do
            //{
            //    Console.WriteLine("opcion 1: refran ");
            //    Console.WriteLine("opcion 2: chiste ");
            //    Console.WriteLine("opcion 3: insulto ");
            //    Console.WriteLine("opcion 4: salir ");
            //    Console.Write("escribe una opcion: ");
            //    y = int.Parse(Console.ReadLine());

            //    switch (y)
            //    {
            //        case 1:
            //            Console.WriteLine("Cuando el grajo vuela bajo hace un frio del carajo");
            //            break;
            //        case 2:
            //            Console.WriteLine("van dos y se cae el del medio");
            //            break;
            //        case 3:
            //            Console.WriteLine("Mongolo");
            //            break;
            //        case 4:
            //            Console.WriteLine("adios");
            //            break;
            //        default:
            //            Console.WriteLine("error");
            //            break;
            //    }

            //} while (y != 4);




            // CUIDADO CON LAS VARIABLES SABER CUANTAS TENEMOS QUE TENER Y DONDE USARLAR
            // CREAR REPETICIONES COTADOR Y LA SUMA, DENTRO DEL FOR CREAR LA VARIABLE PARA DESISGNAR LOS NUMEROS
            //Console.Write("cuantos numeros quieres introducir: ");
            //int rep = int.Parse(Console.ReadLine());
            //int contador = 0;
            //int sumat = 0;
            //for (; contador < rep; contador++)
            //{
            //    Console.Write("introduce esos numeros: ");
            //    int y = int.Parse(Console.ReadLine());
            //    sumat = sumat + y;

            //} 
            //Console.Write("la suma de todos es :" + sumat);
            //Console.ReadLine();







            // IMPORTANTE
            // CREAR VARIABLES PARA EL NUMERO DEL ARRAY O PEDIR QUE TE DIGA CUANTAS QUIERE 
            // CREAR OTRA VARIABLE PARA DETERMINAR LOS NUMEROS QUE TE DA USAR FOR PARA SUMARLOS

            //Console.Write("cuantos numeros quieres introducir?: ");
            //int numbercount = int.Parse(Console.ReadLine());
            //int[] numbers = new int[numbercount];
            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)

            //{
            //    Console.Write("numero" + (i + 1) + ":");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.Write("total:" + total);







            //PEDIMOS UN ARRY DE NUMEROS Y COPIAMOS ESE CONTENIDO A OTRO ARRAY

            Console.WriteLine("introduce 5 numeros: ");
            int repetition = int.Parse(Console.ReadLine());
            int[] numbers = new int[repetition];
            Console.WriteLine("introduce tu array :");
            for (int i = 0; i < numbers.Length; i++)
            {
               
                int x = int.Parse(Console.ReadLine());
                numbers[i] = x;

                
            }
            Console.WriteLine("nueva array:");
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = numbers [i];
                Console.Write(numbers2[i] );
            }
            






        }

    }
}
