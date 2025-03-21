namespace Biblioteca
{
    class FinanciamentoOutros : Financiamento
    {
        private double _comissaoDeAbertura = 1.0;

        private double _taxaDeAmortizacao = 0.05;

        public FinanciamentoOutros(double montante, int prazoPagamento, double jurosAnual, double comissaoDeAbertura, double taxaDeAmortizacao)
            : base(montante, prazoPagamento, jurosAnual)
        {
            _comissaoDeAbertura = comissaoDeAbertura;
            PrazoPagamento = prazoPagamento;
            _taxaDeAmortizacao = taxaDeAmortizacao;
        }

        public override int PrazoPagamento
        {
            get
            {
                return PrazoPagamento;
            }
            set
            {
                if (value >= 0)
                {
                    PrazoPagamento = value;
                }
            }
        }

        public override double ValorPrestacao()
        {
            JurosAnual = (JurosAnual / 12.0 / 100.0);
            Montante = Montante * Math.Pow(JurosAnual, (double)PrazoPagamento) + (Montante * _comissaoDeAbertura);
            _taxaDeAmortizacao = Montante * (_taxaDeAmortizacao / 100);
            return (Montante / PrazoPagamento) + _taxaDeAmortizacao;
        }
    }
}
