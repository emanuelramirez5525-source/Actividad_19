// Desarrolle un programa que solicite la nota de un estudiante, validando que sea un número entre 0 y 100 antes de mostrar si aprueba o reprueba

double nota;

bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese nota");
    correcto = double.TryParse(Console.ReadLine(), out nota);
    if (!correcto || nota < 0 || nota > 100)
    {
        Console.WriteLine( "Nota invalida...");
        correcto = false;
    }
    Console.ReadKey();  



} while (!correcto);

if (nota >= 61)
{
    Console.WriteLine("Aprueba");
}
else
{
    Console.WriteLine("Reprueba");
}

Console.ReadKey();