using System;

namespace PilasMétodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Manejo de pilas estáticas usando métodos";
            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Matricula: 19211740");

            Console.WriteLine();

            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("[1] Inserción");
                Console.WriteLine("[2] Eliminación");
                Console.WriteLine("[3] Imprimir");
                Console.WriteLine("[4] Imprimir el nombre mayor");
                Console.WriteLine("[0] Finalizar programa");

                Console.WriteLine();

                string [] Ciudades = new string [50];
                string ciudad, t = " ";
                int top = 0, oo;

                Console.Write("Ingrese una opción: ");
                int o = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch(o)
                {
                    case 1:
                        do
                        {
                            Console.Write("Ingrese una ciudad [" + (top + 1) + "]: ");
                            ciudad = Console.ReadLine();

                            Console.WriteLine();

                            top = Insertar(Ciudades, top, ciudad);

                            Console.Write("¿Quiere ingresar otra ciudad? [1] Sí, [2] No: ");
                            oo = Convert.ToInt32(Console.ReadLine());
                        }while(oo == 1);

                        Console.Clear();
                    break;

                    case 2:
                        do
                        {
                            Console.WriteLine("Tamaño de pila: [" + top + "]");
                            Console.WriteLine("¿Eliminar ciudades? [1] Sí, [2] No");
                            oo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            if(oo == 1)
                                top = Eliminar(Ciudades, top, t);

                        }while()

                        Console.Clear();
                    break;

                    case 3:
                        Console.WriteLine("Tamaño de la pila: [" + top + "]");

                        Console.WriteLine();

                        Imprimir(Ciudades, top);

                        Console.WriteLine("Presiones cualquier tecla para salir");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 4:

                    break;
                }
            }
            while()
        }
    }
}