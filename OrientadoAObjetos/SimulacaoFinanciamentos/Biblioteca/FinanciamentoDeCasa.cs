namespace Biblioteca
{
    public class FinanciamentoDeCasa: Financiamento
    {
        private double _spread = 1.5;
        public override int PrazoPagamento {  get; set; }

        public string NomeFiador { get; set; }
        public string MoradaFiador { get; set; }
        public int TelefoneFiador { get; set; }
        public int NifFiador { get; set; }
        public double RendimentoFiador { get; set; }

        public FinanciamentoDeCasa(double montante, int prazoPagamento, double jurosAnual, 
            string nomeFiador, string moradaFiador, int telefoneFiador, int nifFiador, double rendimentoFiador)
            :base(montante, jurosAnual)
        {
            PrazoPagamento = prazoPagamento;
            NomeFiador = nomeFiador;
            MoradaFiador = moradaFiador;
            TelefoneFiador = telefoneFiador;
            NifFiador = nifFiador;
            RendimentoFiador = rendimentoFiador;
        }

        public override double ValorPrestacao()
        {
            double jurosMensal = ((JurosAnual +_spread)/ 12.0 / 100.0);
            return (Montante * jurosMensal * Math.Pow(1 + jurosMensal, PrazoPagamento)) / (Math.Pow(1 + jurosMensal, PrazoPagamento) - 1);
        }

        public override string ToString()
        {
            return $"O financiamento da casa possui: \n"
                + base.ToString() 
                + $"\nFiador: {NomeFiador},Morada: {MoradaFiador}\n, NIF: {NifFiador}, Rendimento: {RendimentoFiador:F2}";
        }
    }
}
