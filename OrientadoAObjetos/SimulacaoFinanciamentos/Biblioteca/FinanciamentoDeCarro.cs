namespace Biblioteca
{
    public class FinanciamentoDeCarro : Financiamento
    {
        private double _comissaoDeAbertura = 0.01;
        private double _valorRedisual = 1.0;
        private int _prazoPagamento;

        public override int PrazoPagamento
        {
            get
            {       
                return _prazoPagamento;            
            }
            set
            {
                if (value > 0 && value <= 60)
                    _prazoPagamento = value;
            }        
        }
        public FinanciamentoDeCarro(double montante, int prazoPagamento, double jurosAnual)
            :base(montante, jurosAnual) 
        {
            PrazoPagamento = prazoPagamento;
        }

        public override double ValorPrestacao()
        {
            double jurosMensal =  (JurosAnual / 12.0) / 100.0;
            double montanteCorrigido = Montante + (Montante * _comissaoDeAbertura) + (Montante * _valorRedisual);

            return (montanteCorrigido * jurosMensal * Math.Pow(1 + jurosMensal, PrazoPagamento)) /
                (Math.Pow(1 + jurosMensal, PrazoPagamento) - 1);
        }
        public override string ToString()
        {
            return $"O financiamento do carro possui: \n"
                 + base.ToString();
        }
    }
}
