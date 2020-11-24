using System;

namespace _5_QuickSort
{
    class Program
    {
        static int [] edades = new int [10];
        static int first;
        static int last;
        static int pivote;
        static int i;
        static int j;
        static int temp;
        static int central;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Quick Sort Ascendente.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo.");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para iniciar.");
            Console.ReadKey();

            Console.Clear();

            Ingresar();
            Imprimir();
            Ordenar(edades, first, last);
        }
        static void Ingresar()
        {
            Console.Clear();
            for(int x = 0; x < edades.Length; x++)
            {
                Console.Write("Ingrese una edad: ");
                edades[x] = int.Parse(Console.ReadLine());
            }
        }
        static void Imprimir()
    {
        Console.Clear();
        Console.WriteLine("Orden ingresado.");
        for(int f = 0; f < edades.Length; f++)
        {
            Console.Write("[" + edades[f] + "] ");
        }
        Console.ReadKey();
    }
        static void Ordenar(int [] edades, int first, int last)
        {
            central = (first + last)/2;
            i = first;
            j = last;
            do
            {
                while(edades[j] < pivote) i++;
                while(edades[j] > pivote) j--;
                if(i <= j)
                {
                    temp = edades[i];
                    edades[i] = edades[j];
                    edades[j] = temp;
                    i++;
                    j--;
                }
            }while(i <= j);

            if(first <= j)
                Ordenar(edades, first, j);

            if(i < last)
                Ordenar(edades, i, last);

            Console.Clear();
            Console.WriteLine("Orden ascendente.");
            for(int f = 0; f < edades.Length; f++)
            {
                Console.Write("[" + edades[f] + "] ");
            }
            Console.ReadKey();
        }
    }
}
