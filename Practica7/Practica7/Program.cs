using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {

            int menores = 0, mayores = 0, personas;
            Console.WriteLine("¿Cuantas personas son?");
            personas = Int32.Parse(Console.ReadLine());
            int[] edades = new int[personas]; 
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine($"Ingrese la edad de la persona {i + 1}");
                edades[i] = Int32.Parse(Console.ReadLine());
                if (edades[i] >= 18) mayores++;
                else menores++;                              
            }
            Console.WriteLine($"La cantidad de personas mayores es {mayores}");
            Console.WriteLine($"La cantidad de personas menores es {menores}");
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }
    }
}


