using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            float numero_1 = 0, conversion = 0;

            Console.WriteLine("\nIngrese la cantidad en grados ");
            numero_1 = float.Parse(Console.ReadLine());

            conversion = numero_1 / 180;

            conversio_fraccion(conversion);
        }

        public static void conversio_fraccion(float conversion)
        {
            float numerador = 0, divisor = 0, auxiliar = 0;

            numerador = 1;
            divisor = 1;
            auxiliar = 1;


            while (!(auxiliar == conversion))
            {
                auxiliar = numerador / divisor;
                if (auxiliar < conversion)
                {
                    numerador++;
                }
                else
                {
                    if (auxiliar > conversion)
                    {
                        numerador--;
                        divisor++;
                    }
                }
            }

            Console.Clear();

            Console.WriteLine($"\nEl resultado de la conversion es {conversion}");
            Console.WriteLine($"\nEl resultado en radianes es {numerador}/{divisor} pi Rad \n");



        }
    }
}