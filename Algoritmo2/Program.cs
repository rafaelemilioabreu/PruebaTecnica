using System;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcion();
           void Funcion()
            {
                Console.WriteLine("Digite un numero para la sucesion fibonacci:");
                int a = int.Parse(Console.ReadLine());
                Console.Clear();
                int b = a - 1;
                for(int i =0; i < 5; i++)
                {
                    int c = a + b;
                    Console.WriteLine(c);
                    b = a;
                    a = c;

                }
                Console.ReadKey();
            }

        }
    }
}
