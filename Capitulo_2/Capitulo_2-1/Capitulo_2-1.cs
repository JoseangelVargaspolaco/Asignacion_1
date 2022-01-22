
int perimetro = 0;
int[] Lado = new int[10];
int Ingesar = 0;
string nombre_poligono;

Console.Clear();

Console.WriteLine("\nIngrese el nombre del poligono regular");
nombre_poligono = Console.ReadLine();

Console.WriteLine($"\nIngrese el valor que mide el poligono {nombre_poligono}");
Ingesar = int.Parse(Console.ReadLine());

Console.Clear();

for (int i = 0; i < Ingesar; i++)
{

    Console.WriteLine($"Ingrese el lado {i + 1}");
    Lado[i] = int.Parse(Console.ReadLine());
    perimetro += Lado[i];

}

Console.WriteLine($"El perimetro del proligono es {perimetro}");