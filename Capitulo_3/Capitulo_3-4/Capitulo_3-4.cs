using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {

            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese un numero del 1 al 7 ");
                Console.WriteLine("\nSi quiere salir presione el numero 8 ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES LUNES -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES MARTES -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES MIERCOLES -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES JUEVES -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES VIERNES -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES SAvADO -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n\t\t----- HOY ES DOMINGO -----");
                        Console.WriteLine("\n\n\n\n\n\nPresione enter para salir de la opcion...");
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("\n Saliendo.....");
                        break;

                    default:
                        Console.WriteLine("\n Opcion invalida....");
                        break;

                }

            } while (opcion != 8);
        }
    }
}
