//Desarrolle un programa que solicite el precio de un producto, validando que sea un número decimal mayor que 0, repitiendo hasta que el usuario ingrese correctamente el valor

double precio;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese precio: ");
    correcto = double.TryParse(Console.ReadLine(), out precio);
    
    if (!correcto || precio <= 0)
    {
        Console.WriteLine("Precio invalido...");
        correcto = false;
    }

    Console.ReadKey();



}while (!correcto);

Console.Clear();
Console.WriteLine("Precio valido: " + precio  );