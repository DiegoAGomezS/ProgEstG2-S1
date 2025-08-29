// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        double longitud;
        double ancho = 5;
        double areaVaras;
        double areaManzanas;
        double factorConversion = 1428.8;

        Console.Write("Ingrese la longitud del terreno en varas: ");
        longitud = Convert.ToDouble(Console.ReadLine());

        areaVaras = longitud * ancho;

        areaManzanas = areaVaras / factorConversion;

        Console.WriteLine("El área del terreno es: " + areaManzanas + " manzanas.");
    }
}