using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variable de tipo integer
            // llamada "x".
            //int x;
            //// Inicialización de variable llamada x
            //// con valor 20.
            //x = 20;

            //// Declaración e inicialización.
            //int y = 10;

            //float z = 3.3f;
            //double W = 6.52d;
            //char letra = 'A';
            //string frase = "Hola clase";
            //bool booleanoFalso = false;
            //bool booleanoVerdadero = true;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(W);
            //Console.WriteLine(letra);
            //Console.WriteLine(frase);
            //Console.Write("escriba el primer numero: ");
            //int número = int.Parse(Console.ReadLine());
            //Console.Write("escriba el segundo numero: ");
            //int número1 = int.Parse(Console.ReadLine());
            //Console.Write("La suma es: ");
            //Console.WriteLine(número + número1);
            //Console.Write("La multiplicacion es: ");
            //Console.WriteLine(número * número1);
            //Console.Write("La division es:");
            //Console.WriteLine(número / número1);
            //Console.Write("la resta es: ");
            //Console.WriteLine(número - número1);
            //Console.Write("el resto de " + número + " y " + número1 + " es: ");
            //Console.WriteLine(número % número1);
            //Console.WriteLine(y + z);
            //Console.WriteLine(frase + número);
            //Console.Write("Escribe tu edad: ");
            ////int edad = int.Parse(Console.ReadLine());
            //if (edad >= 65)
            //{
            //    Console.WriteLine("Eres jubilado");
            //}

            //else if (edad >=18)
            //{

            //    Console.WriteLine("Eres mayor de edad");

            //}
            //else
            //{
            //    Console.WriteLine("No Eres mayor de edad");
            //}
            //bool windy = false;
            //bool rain = true;
            //bool sunny = true;

            //if (!windy && (rain || sunny ))
            //{
            //    Console.WriteLine("Puedes coger paraguas");
            //}
            //Console.Write("introduce la nota: ");
            //int nota = int.Parse(Console.ReadLine());
            //if (nota <= 10 && nota >=9)
            //{
            //    Console.WriteLine("Sobresaliente");
            //}

            //else if (nota >= 8 && nota >=7 && nota <=7)
            //{
            //    Console.WriteLine("Notable");
            //}
            //else if (nota >= 6 && nota <=6 )
            //{
            //    Console.WriteLine("Bien");
            //}
            //else if (nota >= 5 && nota <=5)
            //{
            //    Console.WriteLine("Suficiente");
            //}
            //else if (nota <= 4 && nota >=0)
            //{
            //    Console.WriteLine("insificiente");
            //}      


            //else
            //    Console.WriteLine("error");
            Console.Write("Introduce un numero: ");
            int Numero =int.Parse(Console.ReadLine());
                switch(Numero)
            {
                case 1:
                    Console.WriteLine("has introducido un 1");
                    break;
                case 2:
                    Console.WriteLine("has introducido un 2");
                    break;
                case 3:
                    Console.WriteLine("has introducido un 3");
                    break;
                case 4:
                    Console.WriteLine("has introducido un 4");
                    break;
                case 5:
                    Console.WriteLine("has introducido un 5");
                    break;
                case 6:
                    Console.WriteLine("has introducido un 6");
                    break;
                case 7:
                    Console.WriteLine("has introducido un 7");
                    break;
                case 8:
                    Console.WriteLine("has introducido un 8");
                    break;
                case 9:
                    Console.WriteLine("has introducido un 9");
                    break;
                case 10:
                    Console.WriteLine("has introducido un 10");
                    break;
                default:
                    Console.WriteLine("error");
                    break;






            }
            






            Console.WriteLine("Hello World!");
            

        }
    }
}
