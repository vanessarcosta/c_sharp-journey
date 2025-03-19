namespace DemoHeranca
{
    public class EmpregadoComissao : Empregado
    {
        private double _vendasBrutas;

        private double _taxaComissao;

        public EmpregadoComissao(string id, string nomes, string apelido, double vendasBrutas, double taxaComissao)
            : base(id, nomes, apelido)
        {
            _vendasBrutas = vendasBrutas;
            _taxaComissao = taxaComissao;
        }

        public override double SalarioAReceber()
        {
            return _vendasBrutas * _taxaComissao;
        }

        public override string ToString()
        {
            return $"Empregado comissão -> {base.ToString()}, Vendas = {_vendasBrutas}," +
                $"Comissão = {_taxaComissao}, Salário = {SalarioAReceber():C0}";
        }
    }
}
