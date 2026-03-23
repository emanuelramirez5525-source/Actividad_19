//Desarrolle un programa que solicite un número y calcule su raíz cuadrada, validando que el valor ingresado sea numérico y no negativo

double numero;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingresa un número");
    correcto = double.TryParse(Console.ReadLine(), out numero);

    if (! correcto || numero < 0)
    {
        Console.WriteLine("Número invalido..");
        correcto = false;
    }

    Console.ReadKey();

} while (!correcto);

Console.WriteLine("Raiz: " + Math.Sqrt (numero));
Console.ReadKey();
