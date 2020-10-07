using System;

namespace _12_RecDir3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Clear();
            Console.Title = "Programa que suma números naturales recursivamente";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            Console.Write("Ingrese la cantidad de edades que desea guardar: ");

            int [] e = new int [20];

            for(int v = 0; v < 20; v++)
            {
                Console.Write("Ingresa una edad: ");
                e[v] = Convert.ToInt32(Console.ReadLine());


            } 
        }
    }
}
