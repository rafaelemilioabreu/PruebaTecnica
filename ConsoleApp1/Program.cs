using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Funcion();

            void Funcion()
            {
                Console.WriteLine("Escriba la cantidad arrelgos que entrara");
                int cantidad = int.Parse(Console.ReadLine());


                int max = 0;
               
                List<int[]> lista = new List<int[]>();


                for (int i = 0; i < cantidad; i++){
                    Console.WriteLine($"Escriba la cantidad de elementos en la lista {i+1}");
                    int elementos = int.Parse(Console.ReadLine());
                    int[] lista2 = new int[elementos];
                    for (int j = 0; j < elementos; j++)
                    {
                        Console.WriteLine($"Agruegue un elemento a la lista {i+1}");
                        int valor = int.Parse(Console.ReadLine());
                        if (valor > max)
                        {
                            max = valor;
                        }
                        lista2.SetValue(valor, j);

                    }
                    lista.Add(lista2);

                }
                int largo = 0;
                int thelist = 0;
                int count = 0;
                foreach (int[] x in lista){
                   
                   count = count + 1;

                    if (x.Length > largo)
                    {
                        largo = x.Length;
                        thelist = count;
                    }
                    

                }
              
              
               
                Console.WriteLine($"El numero mas alto de todos los elementos es {max}");
                Console.WriteLine($"El largo mas alto de una lista es de {largo} y le pertenece a la lista {thelist}");
                Console.ReadKey();
            }

        }
    }
}
