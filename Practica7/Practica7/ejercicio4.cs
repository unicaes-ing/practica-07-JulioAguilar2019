using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio4
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"Digite los valores de la fila {i + 1}");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }               
            }
            Console.Clear();
            Console.WriteLine("Matriz Transpuestan\n");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
