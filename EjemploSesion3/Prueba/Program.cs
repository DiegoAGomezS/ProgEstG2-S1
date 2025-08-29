// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese un número límite: ");
Convert.ToInt32(Console.ReadLine());

int num;
int sumaImpares = 0;
int sumaPares = 0;
for (num = 1; num <= 100; num++)
{
    if (num % 2 == 0)
        sumaPares += num;
    else
        sumaImpares += num;
}
Console.WriteLine("La suma de pares es: " + sumaPares);
Console.WriteLine("La suma de impares es: " + sumaImpares);