﻿using System;

namespace _3_Hashing
{
    class Program
    {
        static Random r = new Random();
        static int [] c = new int [100];
        static int [] l = new int [100];
        static int N, i = 0, d, dx, col, k;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Metodo Hash aritmética modular.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");
            Console.WriteLine();
            Console.Write("Presione una tecla para continuar.");
            Console.ReadKey();
            
            Console.Clear();

            int opc = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("Generar claves         [1]");
                Console.WriteLine("Mostrar claves         [2]");
                Console.WriteLine("Asignar índices        [3]");
                Console.WriteLine("Mostrar nuevos índices [4]");
                Console.WriteLine("Finalizar programa     [0]");
                Console.WriteLine();
                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opc)
                {
                    case 1:
                    for (int i = 0; i < c.Length; i++)
                    {
                        c[i] = r.Next(100, 1500);
                    }
                    Console.Write("Claves generadas, presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 2:
                    Console.WriteLine("Claves por orden de ingreso.");
                    for (int i = 0; i < c.Length; i++)
                    {
                        Console.WriteLine("[" + (i+1) + "] " + c[i]);
                    }
                    Console.Write("Presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 3:
                    Direcciones();
                    Console.Write("Índices asignados, presione una tecla para continuar.");
                    Console.ReadKey();
                    break;

                    case 4:
                    Buscar();
                    break;

                    default:
                    opc = 0;
                    break;
                }
            } while (opc != 0);
        }
        private static void Direcciones()
        {
            N = c.Length - 1;
            for (int j = 0; j <= N; j++)
            {
                d = (c[j] % N) + 1;
                while (l[i] != 0)
                {
                    col = i + 1;
                    if(col > N)
                        i = 0;
                    else
                        i = col;
                }
                l[i] = c[j];
            }
        }
        private static void Buscar()
        {
            N = l.Length - 1;
            Console.WriteLine("Claves con índices asignados.");
            for (int x = 0; x < l.Length; x++)
            {
                Console.WriteLine("[" + (x+1) + "]" + l[x]);
            }
            Console.WriteLine();
            Console.Write("Ingrese la clave que desee buscar: ");
            k = int.Parse(Console.ReadLine());

            i = (k % N) + 1;

            if(l[i] == k)
            {
                Console.WriteLine("El elemento está en la posición: " + k, i + 1);
                Console.ReadKey();
            }
            else
            {
                dx = i + 1;
                while (dx <= N && l[dx] != l[dx] && l[dx] != 0 && dx != i)
                {
                    dx = dx + 1;
                    if(dx > N)
                        dx = 0;
                }
                if(l[dx] == k)
                    Console.WriteLine("El elemento " + k + "está en la posición " + (dx +1));
                else
                    Console.WriteLine("El elemento no se encuentra en el arreglo: " + k);

                Console.ReadKey();
            }
        }
    }
}