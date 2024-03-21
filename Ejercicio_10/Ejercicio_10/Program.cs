using System;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        //10.	Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor,
        //el del medio y el menor de los números ingresados.
        //Declaracion de variables

        double n1, n2, n3;

        //perdir datos al usuario

        {
            Console.WriteLine("Ingrese el primer numero");
            n1=Convert.todouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            n2=Convert.todouble(Console.ReadLine());
        
    Console.WriteLine("Ingrese el tercer numero");
            n3=Convert.todouble(Console.ReadLine());

            //validacion de datos
            if ((n1>n2)&& (n2 >n3))
            Console.writeLine("El numero mayor es:"+n1);
            Console.writeLine("El numero medio es:"+n2);
            Console.writeLine("El numero menor es:"+n3);

            else if ((n2 >n1)&& (n1>n3)

            Console.writeLine("El numero mayor es:"+n2);
            Console.writeLine("El numero medio es:"+n1);
            Console.writeLine("El numero menor es:"+n3);

            else if ((n3 > n2)&& (n2 >n1))
            Console.writeLine("El numero mayor es:"+n3);
            Console.writeLine("El numero medio es:"+n2);
            Console.writeLine("El numero menor es:"+n1);

            {
            else
            }
            Console.WriteLine("Hay numeros que son iguales.");


    }
}
