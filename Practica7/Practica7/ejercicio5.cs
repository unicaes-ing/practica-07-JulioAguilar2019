using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                Console.WriteLine($"Digite los valores de la fila {i+1}");
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                Console.WriteLine($"Digite los valores de la fila {i+1}");
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            int[,] suma = new int[3, 3];
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write($"{suma[i, j]}  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }
    }
}

