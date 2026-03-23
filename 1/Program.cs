// Desarrolle un programa que solicite la edad de una persona, validando que el valor ingresado sea un número entero válido, repitiendo hasta que el dato sea correcto y mostrando la edad ingresada
int edad;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese su edad");
    correcto = int.TryParse(Console.ReadLine(), out edad );

    if (!correcto || edad < 0)
    {
        Console.WriteLine("Edad invalida.. vuelve a intentar");
        correcto=false;

    }

    Console.ReadKey();


} while (!correcto);

Console.Clear();
Console.WriteLine("Edad es igual: " +  edad);
Console.ReadKey();