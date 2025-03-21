namespace Biblioteca
{
    public abstract class Financiamento
    {
        public double Montante { get; set; }

        public abstract int PrazoPagamento { get; set; }

        public double JurosAnual{ get; set; }

        public Financiamento(double montante, int prazoPagamento, double jurosAnual)
        {
            Montante = montante;
            PrazoPagamento = prazoPagamento;
            JurosAnual = jurosAnual;
        }

        public override string ToString()
        {
            return $"Prestações de {ValorPrestacao():F2} euros com prazo de pagamento de {PrazoPagamento} meses e com montante final de {Montante:F2} euros.";
        }
        public abstract double ValorPrestacao();
    }
}
