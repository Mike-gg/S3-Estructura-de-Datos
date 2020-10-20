using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int [] Sueldos = new int [5];
            int mayor = 0;
            int o = 0;

            Program Me = new Program();
            Me.Smayor(Sueldos, mayor, o);

            Console.WriteLine("el mayor es: " + mayor);
        }
        void Smayor(int[] Sueldos, int mayor, int o)
        {
            if(o<5)
            {
                Console.Write("ingrese un sueldo: ");
                Sueldos[o] = Int32.Parse(Console.ReadLine());

                if(mayor <= Sueldos[o])
                {
                    mayor = Sueldos[o];
                    o++;
                    Smayor(Sueldos, mayor, o);
                }
                else
                    o++;
                    Smayor(Sueldos, mayor, o);
            } 
        }
    }
}
