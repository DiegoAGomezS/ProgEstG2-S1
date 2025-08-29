using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        int x, y, suma;
        Console.WriteLine("Hola mundo");
        Console.WriteLine("Progama hecho por Diego Gómez");
        Console.WriteLine("Ingresa un número");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa otro número");
        y = Convert.ToInt32(Console.ReadLine());
        suma = x + y;
        Console.WriteLine("El resultado es:" + suma);
    }
}