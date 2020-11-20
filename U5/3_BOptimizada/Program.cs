using System;

namespace _3_BOptimizada
{
    class Program
    {
        static double [] sueldos = new double [30];
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Burbuja optimizada.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            Ingresar();
            Imprimir();
            Ordenar();
        }
        public static void Ingresar()
        {
            Console.Clear();
            for(int x = 0; x < sueldos.Length; x++)
            {
                Console.Write("Ingrese un sueldo: ");
                sueldos[x] = double.Parse(Console.ReadLine());
            }
        }
        public static void Ordenar()
        {
            int i = 1; string Ordenado = "si"; double auxi;
            do
            {
                i++;
                Ordenado = "si";
                for(int j = 0; j < (sueldos.Length-1); j++)
                {
                    if(sueldos[j] > sueldos[j+1])
                    {
                    Ordenado = "No";
                    auxi = sueldos[j];
                    sueldos[j] = sueldos[j+1];
                    sueldos[j+1] = auxi;
                    }
                }
                
            } while (i < sueldos.Length && Ordenado != "si");

            Console.Clear();

            Console.WriteLine("Ordenado descendente.");
            for(int f = 29; f > -1; f--)
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
        }
        public static void Imprimir()
        {
            Console.Clear();
            Console.WriteLine("Desordenados.");
            for(int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}