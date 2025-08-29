// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

int nota;
Console.WriteLine("Programa para saber si un estudiante aprobó o no");
Console.WriteLine("Ingresa la nota en número entero:");
nota = Convert.ToInt32(Console.ReadLine());
if (nota >= 70)
{
    Console.WriteLine("Aprobó");
}
else if (nota >= 50 && nota <= 69)
{
    Console.WriteLine("Realizar exámen recuperatorio");
}
else
{
    Console.WriteLine("El estudiante reprobó");
}