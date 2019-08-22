using System;

namespace Actividad_3___Ciclos_For__Oscar_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Imprime los numeros de x hasta y de -1");
            Console.WriteLine("De donde arrancamos el ciclo (Mayor)");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde terminamos el ciclo (Menor)");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto");
            z = Convert.ToInt32(Console.ReadLine());

           if (x > y)
            {
                for (int i = x; i > y; i -= z)
                {
                    Console.WriteLine("i= " + i);
                }
            }
            else
            {
                for (int i = x; i < y; i+=z)
                {
                    Console.WriteLine("i= " + i);
                }
            }
        }
     }
}
