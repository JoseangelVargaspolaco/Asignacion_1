using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            float numero_usuario;

            Console.WriteLine("Ingrese un numero");
            numero_usuario = float.Parse(Console.ReadLine());

            if (numero_usuario % 2 == 0)
            {
                Console.Clear();
                Console.WriteLine($"\n\n\t\tEl numero {numero_usuario} es par \n");
            }
            else
            {

                Console.Clear();
                Console.WriteLine($"\n\n\t\tEl numero {numero_usuario} es impar \n");

            }

        }
    }
}