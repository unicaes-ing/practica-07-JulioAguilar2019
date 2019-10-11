using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica7
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int impares = 0, pares = 0, numeros;
            Console.WriteLine("¿Cuantos números desea ingresar?");
            numeros = Int32.Parse(Console.ReadLine());
            int[] nums = new int[numeros];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}");
                nums[i] = Int32.Parse(Console.ReadLine());
                if (nums[i] % 2 == 0) pares++;
                else impares++;
            }
            Console.WriteLine($"La cantidad de números pares es {pares}");
            Console.WriteLine($"La cantidad de números impares es {impares}");
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }
    }
}
