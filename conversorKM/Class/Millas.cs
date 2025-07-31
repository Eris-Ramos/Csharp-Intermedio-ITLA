

namespace conversorKM.Class
{
      class Millas
    {
        public double Valor { get; set; }

        public Millas(double valor)
        {
            Valor = valor;
        }

        public Kilometros ConvertirAKilometros()
        {
            double resultado = Valor * 1.60934;
            return new Kilometros(resultado);
        }
    }
}
