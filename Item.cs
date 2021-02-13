namespace DesignPatterns
{
    public class Item
    {
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public Item(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}