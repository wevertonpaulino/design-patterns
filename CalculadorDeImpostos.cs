using System;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.1;
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }
        }
    }
}