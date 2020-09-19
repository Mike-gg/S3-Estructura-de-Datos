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
            
            string[] n;
            int[] c;

            n = new string[6];
            c = new int[6];

            for(int v=0; v<6; v++)
            {  
                Console.Write("Escribe un nombre: ");
                n[v] = Console.ReadLine();
                Console.Write("Escribe su calificación: ");
                c[v] = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine();
            }

            for(int v=0; v<6; v++)
            {
                Console.WriteLine(n[v] + " " + c[v]);
            }
        }
    }
}
