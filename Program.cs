using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoBusquedasConsola
{
    class Programa
    {
        static void Main()
        {
            Console.WriteLine("Bienvenido al programa de búsqueda.");
            Console.WriteLine("Ingrese los números separados por coma:");
            string entrada = Console.ReadLine();

            int[] numeros = ParsearEntradaNumeros(entrada);
            if (numeros == null) return;

            Console.WriteLine("Ingrese el número que desea buscar:");
            if (!int.TryParse(Console.ReadLine(), out int valorBuscado))
            {
                Console.WriteLine("Error: Ingrese un número válido.");
                return;
            }

            while (true)
            {
                Console.WriteLine("\nSeleccione un método de búsqueda:");
                Console.WriteLine("1. Búsqueda Secuencial");
                Console.WriteLine("2. Búsqueda Binaria (requiere lista ordenada)");
                Console.WriteLine("3. Búsqueda por Transformación de Claves");
                Console.WriteLine("0. Salir");

                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "0") break;

                Stopwatch cronometro = new Stopwatch();
                cronometro.Start();

                int resultado = -1;
                switch (opcion)
                {
                    case "1": resultado = BusquedaSecuencial.Buscar(numeros, valorBuscado); break;
                    case "2": resultado = BusquedaBinaria.Buscar(numeros, valorBuscado); break;
                    case "3": resultado = BusquedaTransformacionClaves.Buscar(numeros, valorBuscado); break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                cronometro.Stop();

                if (resultado == -1)
                    Console.WriteLine("\nElemento no encontrado.");
                else
                    Console.WriteLine($"\nElemento encontrado en la posición {resultado}.");

                Console.WriteLine($"Tiempo de ejecución: {cronometro.Elapsed.TotalMilliseconds:F3} ms\n");
            }

            Console.WriteLine("Programa finalizado.");
        }

        static int[] ParsearEntradaNumeros(string entrada)
        {
            try
            {
                return entrada.Split(',')
                              .Select(x => int.Parse(x.Trim()))
                              .ToArray();
            }
            catch
            {
                Console.WriteLine("Error: Ingrese solo números separados por coma.");
                return null;
            }
        }
    }
}
