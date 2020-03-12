using System;
using System.Collections.Generic;
using Clase10;

namespace clase_9
    {
    class Program
    {
       
        static void Main(string[] args)
        {
            //Console.WriteLine("Introduce su nombre:  ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Introduce su nota:  ");
            //float nota = float.Parse(Console.ReadLine());
            //Alumno alumno1 = new Alumno(nombre, nota);
            //Alumno alumno2 = new Alumno("Dani", 0f);
            //Alumno alumno3 = new Alumno("Adri", 3f);
            //Alumno alumno4 = new Alumno("paco", 6f); 
            //alumno1.MostarDatos();
            //alumno2.MostarDatos();
            //alumno3.MostarDatos();
            //alumno4.MostarDatos();





            Alumno[] alumnos = new Alumno[3];
            float media = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {                
                Console.WriteLine("Introduce su nombre:  ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduce su nota:  ");
                float nota = float.Parse(Console.ReadLine());
                alumnos[i] = new Alumno(nombre, nota);
                media += nota;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].MostarDatos();
            }
            Console.WriteLine("la media es: " + media / alumnos.Length);
            
        }

    }
}
