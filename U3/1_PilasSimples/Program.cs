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

            int [] edades = new int [100];
            int top = 0;
            int mayor;

            for(top = 0; top < 100; top++)
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1.- Insertar edad");
                Console.WriteLine("2.- Mostrar edades");
                Console.WriteLine("3.- Eliminar edad");
                Console.WriteLine("0.- Finalizar");
                
                Console.WriteLine("");

                Console.Write("Elige una opción: ");
                int o = Convert.ToInt32(Console.ReadLine());

                switch(o)
                {
                    case 1:
                        Console.Clear();
                        
                        Console.Write("Ingresa una edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());

                        if(top == edades.Length)
                        {
                            Console.WriteLine("Pila llena");
                        }
                        else
                        {
                            edades[top] = edad;
                            top = top + 1;
                        }
                    break;

                    case 2:

                        for(top = 0; top < 5; top++)
                        {
                            Console.WriteLine(edades[top]);

                            mayor = edades[top];

                            if(mayor >= edades[top - 1])
                            {
                                Console.WriteLine("La edad mayor es: " + mayor);
                            }
                            else
                            {

                            }
                        }
                    break;

                    case 3:

                        int d;

                        if(top == -1)
                        {
                            Console.WriteLine("Pila Vacía");
                        }
                        else
                        {
                            top--;
                            d = edades[top];
                            edades[top] = 0;
                            Console.Write("El valor eliminado es: " + d);
                        }
                    break;

                    case 0:
                        top = 100;
                    break;
                }
            }
        }
    }
}
