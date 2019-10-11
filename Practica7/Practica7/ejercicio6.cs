using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio6
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[6, 6];
            Random nums = new Random();
            int aleatorio = 0;           
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    aleatorio = nums.Next(10, 100);                       
                    while (condicion(matriz, aleatorio) == false)
                    {
                        aleatorio = nums.Next(10, 100);                                            
                    }
                    matriz[i, j] = aleatorio;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"  {matriz[i, j]}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }

        static bool condicion(int[,] matriz, int nums)
        {
            bool condicion = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (nums == matriz[i, j])
                    {
                        condicion = false;
                    }
                    else
                    {
                        condicion = true;
                    }
                }
            }
            return condicion;
        }
    }
}
