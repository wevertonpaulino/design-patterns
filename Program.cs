using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(1000);
            var calculadorDeImpostos = new CalculadorDeImpostos();

            calculadorDeImpostos.Calcular(orcamento, "ICMS");
            calculadorDeImpostos.Calcular(orcamento, "ISS");
        }
    }
}
