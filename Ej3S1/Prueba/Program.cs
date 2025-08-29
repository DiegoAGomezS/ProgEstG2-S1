// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        double velocidad;
        double tiempo;
        double distancia;

        Console.Write("Ingrese la velocidad promedio en km/h: ");
        velocidad = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo recorrido en horas: ");
        tiempo = Convert.ToDouble(Console.ReadLine());

        distancia = velocidad * tiempo;

        Console.WriteLine("La distancia total recorrida es: " + distancia + " km.");
    }
}

