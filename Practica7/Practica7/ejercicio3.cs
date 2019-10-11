
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ejercicio3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cuantos equipos deseea ingresar?");
            int equipos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos jugadores tienen los equipos?");
            int jugadores = Int32.Parse(Console.ReadLine());
            string[,] liga = new string[equipos, jugadores + 1];
            for (int i = 0; i < liga.GetLength(0); i++)
            {
                Console.WriteLine($"Digite el nombre del equipo{i+1}");
                liga[i, 0] = Console.ReadLine();
                for (int j = 1; j < liga.GetLength(1); j++)
                {
                    Console.WriteLine($"Digite el nombre del jugador {j}");
                    liga[i, j] = Console.ReadLine();
                }              
            }
            Console.Clear();
            Console.WriteLine("La Liga");
            for (int i = 0; i < liga.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre del equipo: {liga[i, 0]}");
                Console.WriteLine("Plantel de jugadores");
                for (int j = 1; j < liga.GetLength(1); j++)
                {
                    Console.WriteLine($"{j} - {liga[i, j]}");
                }                
            }
            Console.WriteLine("Presione <Enter> para continuar");
            Console.ReadKey();
        }
    }
}
