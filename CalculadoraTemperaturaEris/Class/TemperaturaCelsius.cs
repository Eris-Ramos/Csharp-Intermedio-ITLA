using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTemperaturaEris.Class
{
    public class TemperaturaCelsius
    {
        public double Grados { get; set; }

        public TemperaturaCelsius(double grados)
        {
            Grados = grados;
        }

        public double A_Fahrenheit()
        {
            return (Grados * 9 / 5) + 32;
        }

    }

}
