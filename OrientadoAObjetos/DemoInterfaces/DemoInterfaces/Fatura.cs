namespace DemoInterfaces
{
    public class Fatura : IPorPagar
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Fatura(string codigo, string descricao, int quantidade, double preco)
        {
            Codigo = codigo;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Fatura Código: {Codigo}, Descrição: {Descricao}, Preço: {Preco}, Total: {ValorAPagar()}";
        }
        public double ValorAPagar()
        {
            return Quantidade * Preco;
        }
    }
}
