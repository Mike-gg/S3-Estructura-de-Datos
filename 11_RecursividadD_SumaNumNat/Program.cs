using System;

namespace _11_RecursividadD_SumaNumNat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Programa que Suma de números naturales con recursividad directa";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();
            Program Me = new Program();

            Console.Write("Ingrese un número: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            Me.Suma(X, Y);
        }
        void Suma(int X, int Y)
        {
            

        }
    }
}
