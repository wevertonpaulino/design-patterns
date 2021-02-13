using System;

namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public void Calcular(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorMaisDeTresItens();
            IDesconto d2 = new DescontoPorMaisDeDuzentosReais();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            
            double valor = d1.Descontar(orcamento);
            Console.WriteLine(valor);
        }
    }
}