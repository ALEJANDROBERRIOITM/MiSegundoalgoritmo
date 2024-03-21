using System;

namespace Parcial1_Logic_2024_Punto2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Hora de salida del primer tren (10:00 AM)

            TimeSpan horaSalidaPrimerTren = new TimeSpan(10, 0, 0);

            // Velocidades de los trenes en km/h
            int velocidadPrimerTren = 80;

            int velocidadSegundoTren = 100;

            // Calcular la hora en que el segundo tren alcanzará al primero
            // Distancia entre los trenes = velocidad * tiempo
            // Tiempo = distancia / velocidad 
            // El segundo tren sale 1 hora después del primero(11 AM),  entonces calculamos la distancia que el primer tren recorre en esa hora
            double distanciaRecorridaPrimerTren = velocidadPrimerTren * 1; // El primer tren recorre 80 km en 1 hora
            double tiempoParaAlcanzar = distanciaRecorridaPrimerTren / (velocidadSegundoTren - velocidadPrimerTren);


            // Sumamos el tiempo que tarda el segundo tren en alcanzar al primero a la hora de salida del segundo tren

            TimeSpan horaAlcanzado = horaSalidaPrimerTren.Add(TimeSpan.FromHours(tiempoParaAlcanzar));


            // Mostrar la hora en pantalla

            Console.WriteLine("El segundo tren alcanzará al primer tren a las: " + horaAlcanzado.ToString(@"hh\:mm\:ss"));
        }
    }

}
