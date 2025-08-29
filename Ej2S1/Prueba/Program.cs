// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        double velocidad;
        double distancia = 40;
        double tiempo;

        Console.Write("Ingrese la velocidad promedio en km/h: ");
        velocidad = Convert.ToDouble(Console.ReadLine());

        tiempo = distancia / velocidad;

        Console.WriteLine("El tiempo total del viaje es: " + tiempo + " horas.");
    }
}
