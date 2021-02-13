namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 3)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Valor > 200)
            {
                return orcamento.Valor * 0.05;
            }
            
            return 0;
        }
    }
}