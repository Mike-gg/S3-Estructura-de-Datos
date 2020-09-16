using System;

namespace Estructuras_primitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "PROGRAMA USANDO ESTRUCTURAS PRIMITIVAS";
            
            int x = 0;
            float y = 0;

            Console.WriteLine("Menú de opciones a realizar");
            Console.WriteLine("1.- Raíz Cuadrada");
            Console.WriteLine("2.- Potencias");
            Console.WriteLine("3.- Valor absoluto");
            Console.WriteLine("4.- Número máximo");
            Console.WriteLine("5.- Número mínimo");
            Console.WriteLine("6.- Truncar valor decimal");
            Console.WriteLine("7.- Redondear");

            Console.WriteLine("Seleccione una opción: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa un número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro número: ");
            y = float.Parse(Console.ReadLine());

            if(z<=7)
            {
                switch(z)
                {
                    case 1:
                    
                    break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
                case 6:
                break;
                case 7:
                break;
                }
            }
            else{Console.WriteLine("Ingresa una de las 7 opciones.");}

        }
    }
}
