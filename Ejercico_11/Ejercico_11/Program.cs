using System;

namespace Ejercico_11
{
    internal class Program
    {
        static void Main(string[] args)

        // Mostrar las opciones de pizza al usuario
        {
            Console.WriteLine("Bienvenido a la pizzería Berrio!");
            Console.WriteLine("Por favor, elija el tipo de pizza que quieres:");
            Console.WriteLine("1. Pizza vegetariana");
            Console.WriteLine("2. Pizza no vegetariana");

            // Leer la elección del usuario
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Mostrar los ingredientes según la elección del usuario
            switch (opcion)

            {

                case 1:
                    Console.WriteLine("Usted eligió una pizza vegetariana.");
                    Console.WriteLine("Ingredientes: Pimiento y tofu.");
                    break;
                case 2:
                    Console.WriteLine("Usted eligió una pizza no vegetariana.");
                    Console.WriteLine("Ingredientes: Peperoni, Jamón y Salmón.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione 1 o 2.");
                    break;



            }
        }
    }
}
