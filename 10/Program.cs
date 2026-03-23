//Desarrolle un programa que solicite la cantidad de productos a comprar, validando que sea un número entero positivo y luego simule el ingreso de esos productos

int cantidad;
bool correcto;

do
{

    Console.Clear();
    Console.WriteLine("Ingrese cantidad de producto ");
    correcto = int.TryParse(Console.ReadLine(), out cantidad);  
    
    if (!correcto || cantidad <= 0)
    {
        Console.WriteLine("Cantidad invalida... ");
        correcto = false;
    }

    Console.ReadKey();



} while (!correcto);

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Producto " + i + ":");
    Console.ReadLine();
}

Console.ReadKey();