// Desarrolle un programa que solicite el año de nacimiento de una persona, validando que sea un número válido y que esté en un rango lógico (por ejemplo entre 1900 y el año actual)

int anio;
int actual = DateTime.Now.Year;
bool correcto;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese fecha de nacimiento");
    correcto = int.TryParse(Console.ReadLine(), out anio);    
    
    if (!correcto || anio < 1900 || anio > actual)
    {
        Console.WriteLine("Año invalido...");
        correcto = false;
    }

    Console.ReadKey();



}while (!correcto);

Console.WriteLine("Año valido: " + anio);
Console.ReadKey();