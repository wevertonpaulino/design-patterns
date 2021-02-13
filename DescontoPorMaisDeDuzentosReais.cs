namespace DesignPatterns
{
    public class DescontoPorMaisDeDuzentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 200.0)
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Descontar(orcamento);
        }
    }
}