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
        Console.WriteLine("1. Celsius a Fahrenheit");                 //aca se muestra las opciones de eleccion a convertir la temperatura
        Console.WriteLine("2. Fahrenheit a Celsius");
        Console.Write("Seleccione una opción (1 o 2): ");          //el usuario debe elegir atravez de un readline la opcion que desea convertir
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            Console.Write("Ingrese la temperatura en Celsius: ");
            double tempC = Convert.ToDouble(Console.ReadLine());
            TemperaturaCelsius celsius = new TemperaturaCelsius(tempC);                   //se crea un objeto de la clase TemperaturaCelsius con el valor ingresado por el usuario
            Console.WriteLine($"{tempC}°C = {celsius.A_Fahrenheit():F2}°F");
        }
        else if (opcion == "2")
        {
            Console.Write("Ingrese la temperatura en Fahrenheit: ");
            double tempF = Convert.ToDouble(Console.ReadLine());
            TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit(tempF);         // se crea un objeto de la clase TemperaturaFahrenheit con el valor ingresado por el usuario
            Console.WriteLine($"{tempF}°F = {fahrenheit.A_Celsius():F2}°C");
        }
        else
        {
            Console.WriteLine("Opción no válida.");           // si el usuario ingresa una opcion no valida se le muestra un mensaje de error
        }

        Console.WriteLine("Presione cualquier tecla para salir...");    // se le indica al usuario que presione una tecla para salir del programa.
        Console.ReadKey();
    }
}