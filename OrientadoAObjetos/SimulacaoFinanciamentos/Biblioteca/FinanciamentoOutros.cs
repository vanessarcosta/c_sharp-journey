namespace Biblioteca
{
    public class FinanciamentoOutros : Financiamento
    {
        private double _comissaoDeAbertura = 0.01;

        private double _taxaDeAmortizacao = 0.05;
        public override int PrazoPagamento { get; set; }

        public FinanciamentoOutros(double montante, int prazoPagamento, double jurosAnual)
            : base(montante, jurosAnual)  
        {
            PrazoPagamento = prazoPagamento;
        }

        public override double ValorPrestacao()
        {
            double jurosMensal = (JurosAnual / 12.0 / 100.0);
            double montantecorrigido = Montante + (Montante * _comissaoDeAbertura);
            double prestacaoBase = (montantecorrigido * jurosMensal * Math.Pow(1 + jurosMensal, PrazoPagamento)) / (Math.Pow(1 + jurosMensal, PrazoPagamento) - 1);
            double taxaAmortizacao = montantecorrigido * (_taxaDeAmortizacao / 100); 
            return prestacaoBase + taxaAmortizacao;
        }
    }
}
