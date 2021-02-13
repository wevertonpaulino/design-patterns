using System;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcular(orcamento);
            Console.WriteLine(valor);
        }
    }
}