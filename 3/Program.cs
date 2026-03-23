// Desarrolle un programa que solicite la cantidad de estudiantes en un curso, validando que sea un número entero positivo, evitando valores negativos o letras

int cantidad;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese la cantidad");
    correcto = int.TryParse(Console.ReadLine(), out cantidad);

    if (correcto || cantidad <= 0)
    {
        Console.WriteLine("Cantidad invalida...");
        correcto = false;
    }

    Console.ReadKey();



} while (!correcto);

Console.WriteLine("La cantidad de estudiantes es: " + cantidad);
Console.ReadKey();  