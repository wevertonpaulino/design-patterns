namespace DesignPatterns
{
    public class DescontoPorMaisDeTresItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 3)
            {
                return orcamento.Valor * 0.1;
            }

            return Proximo.Descontar(orcamento);
        }
    }
}