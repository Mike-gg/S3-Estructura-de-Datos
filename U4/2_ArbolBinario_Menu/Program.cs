using System;

namespace _2_ArbolBinario_Menu
{
    class Program
    {
        public class Arbol
        {
            public double info;
            public Arbol izq;
            public Arbol der;
            public Arbol()
            {
                info = 0;
                izq = null;
                der = null;
            }
        }
        static Arbol re;
        static Arbol raiz = null;
        static float cal;
        static Arbol temp;
        static int opc;

        static void Main(string[] args)
        {
            Console.Clear();

            Console.Title = "Menú de árbol binario.";

            Console.WriteLine("Alumno: Terrazas Rojo Miguel Arturo");
            Console.WriteLine("Materia: 19211740");
            Console.WriteLine();
            Console.Write("Iniciar programa.");
            Console.Readkey();
            Console.Clear();

            do
            {
                Console.WriteLine("-----MENU-----");
                Console.WriteLine("[1] Insertar  ");
                Console.WriteLine("[2] Eliminar  ");
                Console.WriteLine("[3] Buscar    ");
                Console.WriteLine("[4] Recorrer  ");
                Console.WriteLine("[0] Salir     ");
                Console.WriteLine();
                Console.Write("Ingresa una opción: ");
                opc = int.parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                    do
                    {
                        Insertar();
                    
                        Console.Write("¿Ingresar otra calificación? [1] Sí, [2] No: ");
                        opc = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                    }while(opc == 1);
                break;

                case 2:
                    do
                    {
                        Console.Write("Calificación por eliminar: ");

                    } while (opc == 1);
                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Recorrido por PostFijo.");
                    re = raiz;
                    PreOrden(re);
                    Console.ReadKey();
                break;

                default:
                    opc = 0;
                break;
                    
                    default:
                }

            } while (opc != 0);
        }
    }
}
