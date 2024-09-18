// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese un numero entero");

string entrada = Console.ReadLine();
int valorEntero = 0;
string signo = string.Empty;
string cadenaBinaria = string.Empty;
try
{
    if (string.IsNullOrEmpty(entrada))
    {
        Console.WriteLine("No se recibio ningun parametro");
        return;
    }

    valorEntero = Convert.ToInt32(entrada);

    if (valorEntero < 0)
    {
        signo = "-";
        valorEntero = valorEntero * -1;
    }

    while (valorEntero != 0)
    {
        if (valorEntero % 2 == 0)
        {
            valorEntero = valorEntero / 2;
            cadenaBinaria = cadenaBinaria.Insert(0, "0");
        }
        else
        {
            valorEntero -= 1;
            valorEntero = valorEntero / 2;
            cadenaBinaria = cadenaBinaria.Insert(0, "1");
        }
    }
    Console.WriteLine($"El valor decimal de {entrada} es: {cadenaBinaria.Insert(0, signo)}");
}
catch (FormatException fEx)
{
    Console.WriteLine("El valor ingresado debe ser entero");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    entrada = string.Empty;
    valorEntero = 0;
    signo = string.Empty;
    cadenaBinaria = string.Empty;
}