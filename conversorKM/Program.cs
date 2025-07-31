using conversorKM.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversión de distancias");
        Console.WriteLine("1. Convertir de Kilómetros a Millas");
        Console.WriteLine("2. Convertir de Millas a Kilómetros");
        Console.Write("Elige una opción (1 o 2): ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Introduce la distancia en kilómetros: ");
            double km = double.Parse(Console.ReadLine());
            Kilometros kilometros = new Kilometros(km);
            Millas millas = kilometros.ConvertirAMillas();
            Console.WriteLine($"{kilometros.Valor} kilómetros son {millas.Valor:F4} millas.");
        }
        else if (opcion == 2)
        {
            Console.Write("Introduce la distancia en millas: ");
            double mi = double.Parse(Console.ReadLine());
            Millas millas = new Millas(mi);
            Kilometros kilometros = millas.ConvertirAKilometros();
            Console.WriteLine($"{millas.Valor} millas son {kilometros.Valor:F4} kilómetros.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
