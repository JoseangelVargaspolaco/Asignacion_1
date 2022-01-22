
string[] nombres = new string[20];

Console.Clear();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"\nEscribe el nombre {i + 1} para imprimir en consola");
    nombres[i] = Console.ReadLine();
}

Console.Clear();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"El nombre {i + 1} es {nombres[i]} \n");

}



