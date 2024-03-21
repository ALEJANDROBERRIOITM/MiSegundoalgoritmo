using System;
using System.ComponentModel.Design;


namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
            //Leer los dos valores de entrada
            Console.WriteLine("Ingrese el primer valor:");
            double primerValor = Convert.ToDouble(Console.readline());

        Console.WriteLine("Ingrese el segundo valor:");
            double segundoValor = Convert.ToDouble(Console.readline());

        //Validar la interminacion
        IF(segundoValor == 0)

        {
            Console.WriteLine("La division por cero no esta definida");

        }
        else
        {
        //Calcular el mayor y el menor
        double mayor = Math.Max(primerValor, segundoValor);
        double menor = Math.Max(primerValor, segundoValor);

        //Realizar la division del mayor entre el menor
        double resultado = mayor / menor;

        //Imprimir el resultado
        Console.WriteLine ("El resultado de la division del mayor entre el menor es: " + resultado );

    }
}
