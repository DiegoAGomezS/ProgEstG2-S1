// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

int num;
Console.WriteLine("Programa para saber si un número es positivo, negativo o cero");
Console.WriteLine("Ingresa un número entero:");
num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("Número positivo");
}
else if (num < 0)
{
    Console.WriteLine("Numero negativo");
}
else
{
    Console.WriteLine("Numero 0");
}