using System;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Ingrese el peso del paciente (en  kilos):");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la altura del paciente ( metros):");
                double altura = double.Parse(Console.ReadLine());

                double imc = CalcularIMC(peso, altura);
                string categoria = ClasificarIMC(imc);

                Console.WriteLine($"El IMC del paciente es: {imc:F2}");
                Console.WriteLine($"Categoría: {categoria}");

                Console.WriteLine("¿Desea calcular el IMC de otro paciente? (Si/No)");
                char respuesta = char.Parse(Console.ReadLine());

                if (respuesta != 'S' && respuesta != 's')
                {
                    continuar = false;
                }

                Console.WriteLine();
            }
        }

        static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string ClasificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Peso muy insuficiente";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Este es un peso saludable";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                return "Tienes Sobrepeso";
            }
            else
            {
                return "Esta gordito";
            }

        }
    }
}
