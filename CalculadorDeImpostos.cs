using System;

namespace DesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                var icms = new ICMS();
                var valor = icms.Calcular(orcamento);

                Console.WriteLine(valor);
            }
            else if ("ISS".Equals(imposto))
            {
                var iss = new ISS();
                var valor = iss.Calcular(orcamento);
                
                Console.WriteLine(valor);
            }
        }
    }
}