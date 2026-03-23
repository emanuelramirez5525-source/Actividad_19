//Desarrolle un programa que solicite un número entero y determine si es par o impar, validando previamente que el dato ingresado sea correcto

int num;

bool correcto;

do
{

    Console.Clear();
    Console.WriteLine("Ingrese un número");
    correcto = int.TryParse(Console.ReadLine(), out num );
    
    if (! correcto)
    {
        Console.WriteLine("Número invalido...");
    }

    Console.ReadKey();

} while (!correcto);

Console.Clear();

if (num % 2 == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es impar");
}

Console.ReadKey();