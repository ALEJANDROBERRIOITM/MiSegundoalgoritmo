using System;

namespace Ejercicio2_SegmentoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos
            //Declaracion de variables:

            double seg1, seg2, seg3, suma;
            string mensaje = "sepuede construir un triangulo";

            //pedir los datos :
            Console.Write("SEGMENTO POSITIVO")
            Console.Write("Ingrese el primer segmento:\n");
                seg1 = Convert.ToDouble(Console.readline());

            Console.Write("SEGMENTO POSITIVO")
            Console.Write("Ingrese el primer segmento:\n");
                seg2 = Convert.ToDouble(Console.readline());

            Console.Write("SEGMENTO POSITIVO");
            Console.Write("Ingrese el primer segmento:\n");
                seg3 = Convert.ToDouble(Console.readline());

            //Validar
            
            
            
            if ((seg1 + seg2) > seg3)

            {
                if ((seg1 + seg3) >seg2)

                {
                    if ((seg2 + seg3) >seg1)


                    Console.WriteLine(string.Format("si {0}", mensaje));

                

                }
            }

        }

    }
            else
           }

            Console.WriteLine(string.Format("no {0}", mensaje));

            }


            
        }
    }
}
