﻿using System;

namespace _8_ColaCircularEstática
{
    class Program
    {
        static int i;
        static int f;
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo de Colas Circulares de manera estática";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            int n = (20-1);
            string [] Nombres = new string[n];
            string name = " ";
            int opc;

            do
            {
                Console.Clear();

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Recorrer  ");
                Console.WriteLine("[0] Salir     ");

                Console.WriteLine();

                Console.Write("Ingrese una opción: ");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(opc)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese un nombre: ");
                            name = Console.ReadLine();

                            Insertar(Nombres, n, name);

                            Console.Write("¿Desea ingresar otro nombre? [1] Sí, [2] No: ");
                            opc = Convert.ToInt32(Console.ReadLine());
                        }while(opc == 1);
                    break;

                    case 2:
                        Eliminar(Nombres, n, name);
                    break;

                    case 3:
                        Imprimir(Nombres, n, name);
                    break;
                }
            }while(opc != 0);
        }
        public static void Insertar(string[] Nombres, int n, string name)
        {
            if(f == n)
            {
                f = 1;
                if(i == f)
                {
                    Console.WriteLine(" Cola llena");

                    if(f == 1)
                        f = n;
                    else
                        f = f - 1;
                }
                else
                {
                    Nombres[f] = name;
                }
            }
            else
            {
                if((f+1) == i){}
                
                else
                {
                    f = f + 1;
                    Nombres[f] = name;
                }
            }
            if(i == 0)
                i = 1;

            Console.WriteLine();
        }
        public static void Eliminar(string[] Nombres, int f,  string name)
        {

        }
        public static void Imprimir(string[] Nombres, int n, string name)
        {
            for(int a = 0; a < n; a++)
            {
                Console.WriteLine(Nombres[a]);
            }
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
        }
    }
}
