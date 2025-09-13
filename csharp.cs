using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Función de búsqueda iterativa
        static bool BuscarTitulo(List<string> catalogo, string tituloBuscado)
        {
            foreach (string titulo in catalogo)
            {
                if (titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            // Catálogo de revistas
            List<string> catalogo = new List<string>
            {
                "National Geographic",
                "Scientific American",
                "Time",
                "Forbes",
                "Nature",
                "The Economist",
                "Popular Science",
                "Wired",
                "Harvard Business Review",
                "MIT Technology Review"
            };

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== Catálogo de Revistas ===");
                Console.WriteLine("1. Buscar título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloBuscado = Console.ReadLine();

                        bool encontrado = BuscarTitulo(catalogo, tituloBuscado);

                        if (encontrado)
                            Console.WriteLine("Resultado: Encontrado");
                        else
                            Console.WriteLine("Resultado: No encontrado");

                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Gracias por usar el catálogo.");
        }
    }
}
