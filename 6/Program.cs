//Desarrolle un programa que solicite una fecha, validando que el formato ingresado sea correcto, y luego mostrarla en formato corto

DateTime fecha;
bool correcto;

do
{
    Console.Clear();

    Console.WriteLine("Ingrese una fecha");
    correcto = DateTime.TryParse(Console.ReadLine(), out fecha);

    if (!correcto)
    {
        Console.WriteLine("Fecha invalida...");
    }

    Console.ReadKey();


} while (!correcto);

Console.WriteLine("Fecha corta " + fecha.ToShortDateString());
Console.ReadKey();