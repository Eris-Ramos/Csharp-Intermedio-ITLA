

namespace conversorKM.Class
{
      class Kilometros
    {
        public double Valor { get; set; }

        public Kilometros(double valor)
        {
            Valor = valor;
        }

        public Millas ConvertirAMillas()
        {
            double resultado = Valor / 1.60934;
            return new Millas(resultado);
        }
    }
}
