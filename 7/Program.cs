// Desarrolle un programa que solicite el salario de un empleado, validando que sea un número decimal válido mayor o igual a 0

double salario;

bool correcto;

do
{
    Console.Clear();

    Console.WriteLine("Ingrese un salario");
    correcto = double.TryParse(Console.ReadLine(), out salario);    

    if (!correcto || salario < 0)
    {
        Console.WriteLine("Salario invalido ...");
        correcto=false;
    }

    Console.ReadKey();

} while (!correcto);

Console.WriteLine("Salario valido: " + salario);
Console.ReadKey();
