using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraTemperaturaEris.Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("1. Celsius a Fahrenheit");
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.Write("Seleccione una opción (1 o 2): ");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Write("Ingrese la temperatura en Celsius: ");
            double tempC = Convert.ToDouble(Console.ReadLine());
            TemperaturaCelsius celsius = new TemperaturaCelsius(tempC);
            Console.WriteLine($"{tempC}°C = {celsius.A_Fahrenheit():F2}°F");
        }
        else if (opcion == "2")
        {
            Console.Write("Ingrese la temperatura en Fahrenheit: ");
            double tempF = Convert.ToDouble(Console.ReadLine());
            TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit(tempF);
            Console.WriteLine($"{tempF}°F = {fahrenheit.A_Celsius():F2}°C");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}