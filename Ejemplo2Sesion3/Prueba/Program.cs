// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        // 1. Declarar variables
        double longitud;
        double ancho = 5; // Ancho fijo en varas
        double areaVaras;
        double areaManzanas;
        double factorConversion = 1428.8; // 1 manzana = 1428.8 varas²

        // 2. Pedir al usuario la longitud del terreno
        Console.Write("Ingrese la longitud del terreno en varas: ");
        longitud = Convert.ToDouble(Console.ReadLine());

        // 3. Calcular área en varas²
        areaVaras = longitud * ancho;

        // 4. Convertir a manzanas
        areaManzanas = areaVaras / factorConversion;

        // 5. Mostrar resultado
        Console.WriteLine("El área del terreno es: " + areaManzanas + " manzanas.");
    }
}