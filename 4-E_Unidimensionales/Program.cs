using System;

namespace _4_E_Unidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Estructuras Unidimensionales";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: #19211740");
            Console.WriteLine();
            string [,] a;
            a = new string[6,2];

            //Console.WriteLine("Lista de alumnos ")
            for(int c = 0; c < 6; c++)
            {
                for(int f = 0; f < 2; f++)
                {
                    Console.Write("Ingresa el nombre de un estudiante: ");
                    a[f,c] = Console.ReadLine();
                    Console.Write("Ingresa su calificación: ");
                    a[f,c] = Console.ReadLine();
                    Console.WriteLine();
                }
            }

            for(int c = 0; c < 6; c++)
            {
                for(int f = 0; f<2; f++)
                {
                    Console.Write(" " + a[c,f]);
                }
            }

        }
    }
}
