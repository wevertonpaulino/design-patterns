using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(1000);
            var calculadorDeImpostos = new CalculadorDeImpostos();
            var icms = new ICMS();
            var iss = new ISS();

            calculadorDeImpostos.Calcular(orcamento, icms);
            calculadorDeImpostos.Calcular(orcamento, iss);
        }
    }
}
