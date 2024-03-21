using System;

namespace Parcial1_Logic_2024_I
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Sueldo base del vendedor
            double sueldoBase = 1985; 
           // Ventas realizadas por el vendedor en el mes
            double[] ventas = { 50000, 30000, 4500 }; 

           // Cálculo de comisiones por cada venta
            double[] comisiones = new double[ventas.Length];
            double mayorComision = 0;
            int indiceMayorComision = -1;
            double totalComisiones = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                comisiones[i] = ventas[i] * 0.10; // comision por cada venta
                totalComisiones += comisiones[i];
                if (comisiones[i] > mayorComision)
                {
                    mayorComision = comisiones[i];
                    indiceMayorComision = i;
                }
            }
            // Cálculo del total recibido en el mes
            double totalMes = sueldoBase + totalComisiones;
            // Cálculo del promedio de comisiones por venta
            double promedioComisiones = totalComisiones / ventas.Length;
            // Verificar si supera el objetivo de ventas
            double totalVentas = 0;
            foreach (double venta in ventas)
            {
                totalVentas += venta;
            }
            // Mensaje si supera el objetivo de ventas
            if (totalVentas >= 1000000)
            {
                totalMes += 100000; // Suma del beneficio extra
                Console.WriteLine("¡Ha superado el objetivo de ventas la empresa te obsequia un beneficio  de $100.000!");
            }
            else
            {
                Console.WriteLine("No lograste el objetivo de ventas.");
            }
            // Mostrar resultados
            Console.WriteLine("Dinero obtenido por comisiones por las tres ventas en el mes: $" + totalComisiones);
            Console.WriteLine("Total recibido en el mes (sueldo base + comisiones): $" + totalMes);
            Console.WriteLine("Venta que generó la mayor comisión: Venta " + (indiceMayorComision + 1));
            Console.WriteLine("Promedio de comisiones por venta: $" + promedioComisiones);
        }
    }
}