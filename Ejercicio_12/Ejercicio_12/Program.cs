using System;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)


        // Solicitar los coeficientes a, b y c
        Console.WriteLine("Ingrese el coeficiente a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el coeficiente b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el coeficiente c:");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calcular el discriminante
        double discriminante = b * b - 4 * a * c;

        // Calcular las soluciones
        if (discriminante > 0)
        {
            // Dos soluciones reales distintas
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
        Console.WriteLine("Las soluciones son:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }

        else if (discriminante == 0)
    
            // Una solución real única
            double x = -b / (2 * a);
    Console.WriteLine("La solución única es:");
            Console.WriteLine("x = " + x);
        }
     else
{

    // No hay soluciones reales

    Console.WriteLine("La ecuación no tiene soluciones reales.");
    Console.WriteLine("El discriminante es negativo.");
}
     }
    

        


        
    

        
        
    

