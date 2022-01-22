using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            float Cambio, dolares, euros = 0;

            Console.WriteLine("Ingrese el tipo de cambio del dia:  ");
            Cambio = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dolares a convertir en euros ");
            dolares = float.Parse(Console.ReadLine());

            euros = (dolares * Cambio);
            Console.WriteLine($"La conversion es {euros} euros");

        }
    }
}