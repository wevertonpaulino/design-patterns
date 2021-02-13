using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(1000.0);
            orcamento.AdicionarItem(new Item("Mouse", 155.0));
            orcamento.AdicionarItem(new Item("Teclado", 120.0));
            orcamento.AdicionarItem(new Item("Fone", 90.0));
            orcamento.AdicionarItem(new Item("Monitor", 550.0));

            Strategy(orcamento);
            ChainOfResponsibility(orcamento);
        }

        private static void Strategy(Orcamento orcamento)
        {
            var calculadorDeImpostos = new CalculadorDeImpostos();
            var icms = new ICMS();
            var iss = new ISS();

            calculadorDeImpostos.Calcular(orcamento, icms);
            calculadorDeImpostos.Calcular(orcamento, iss);
        }

        private static void ChainOfResponsibility(Orcamento orcamento)
        {
            var calculadorDeDescontos = new CalculadorDeDescontos();
            calculadorDeDescontos.Calcular(orcamento);
        }
    }
}
