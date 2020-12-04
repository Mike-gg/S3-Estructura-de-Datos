using System;

namespace _9_Mezcla
{
    class Program
    {
        static int [] Edades = new int [15];
        static Random r = new Random();
        static void Main(string[] args)
        {   
            Console.Clear();

            Console.Title = "Burbuja simple.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();

            Console.Clear();

            for(int x = 0; x < Edades.Length; x++)
            {
                Edades[x] = r.Next(0,100);
            }
            int i = 0, f = Edades.Length;

            Console.WriteLine("Orden de ingreso: ");
            foreach (int x in Edades)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Ordenados ascendentemente: ");
            Mezcla(Edades, i,f);   
            Console.ReadKey();
        }
        private static void Mezcla(int [] Edades, int i, int f)
        {
            if(i == f)
            {
                return;
            }
            int m = (i + f) / 2;
            Mezcla(Edades, i, m);
            Mezcla(Edades, m+1, f);
            int [] ax = Merge(Edades, i, m, m+1, f);
            Array.Copy(ax, 0, Edades, i, ax.Length); 
            Imprimir(ax);
        }
        private static int [] Merge(int [] x, int i1, int f1, int i2, int f2)
        {
            int a = i1, b = i2;
            int [] M = new int [f1 - i1 + f2 - i2 + 2];

            for(int i = 0; i < M.Length; i++)
            {
                if(b != M.Length)
                {
                    if(a > f1 && b <= f2)
                    {
                        M[i] = x[b];
                        b++;
                    }
                    if(b > f2 && a <= f1)
                    {
                        M[i] = x[a];
                        a++;
                    }
                    if(a <= f1 && b <= f2)
                    {
                        if(x[b] <= x[a])
                        {
                            M[i] = x[b];
                            b++;
                        }
                        else
                        {
                            M[i] = x[a];
                            a++;
                        }
                    }
                }
                else
                {
                    if(a <= f1)
                    {
                        M[i] = x[a];
                        a++;
                    }
                }
            }
            return M;
        }
        private static void Imprimir(int [] ax)
        {
            foreach (int x in ax)
            {
                Console.WriteLine(x);
            }
        }
    }
}
