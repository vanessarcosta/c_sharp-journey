namespace Biblioteca
{
    public class FinanciamentoDeCasa: Financiamento
    {
        private double _spread = 1.5;
        
        public FinanciamentoDeCasa(double montante, int prazoPagamento, double jurosAnual)
            :base(montante,prazoPagamento, jurosAnual) { }
        public override double ValorPrestacao()
        {
            double jurosMensal = ((JurosAnual +_spread)/ 12.0 / 100.0);
            return (Montante * jurosMensal * Math.Pow(1 + jurosMensal, PrazoPagamento)) / (Math.Pow(1 + jurosMensal, PrazoPagamento) - 1);
        }

        public override string ToString()
        {
            return $"O financiamento da casa possui: \n" + base.ToString();
        }
    }
}
