using System;

namespace PilasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Programa de pilas estáticas";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine("");

            int [] edad = new int [100];
            int top = 0;

            Console.WriteLine("---------Menu---------");
            Console.WriteLine("1.- Ingresar edades");
            Console.WriteLine("2.- Mostrar mayor edad");
            Console.WriteLine("3.- Mostrar edades");
            Console.WriteLine("4.- Eliminar edades");
            Console.WriteLine("5.- Finalizar programa");

            Console.WriteLine("");

            Console.Write("Ingresa la opción que deseas realizar: ");
            int o = Convert.ToInt32(Console.ReadLine());

            switch(o)
            {
                case 1:
                    for(top = 0; top <= 100; top++ )
                    {
                        Console.Write("Ingresa una edad: ");
                        edad[top] = Convert.ToInt32(Console.ReadLine());
                    }
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
            }
        }
    }
}
