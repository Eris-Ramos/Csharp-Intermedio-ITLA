using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTemperaturaEris.Class
{
    public class TemperaturaFahrenheit
    {
        public double Grados { get; set; }

        public TemperaturaFahrenheit(double grados)
        {
            Grados = grados;
        }

        public double A_Celsius()
        {
            return (Grados - 32) * 5 / 9;
        }
    }
}
