namespace Biblioteca
{
    public abstract class Financiamento
    {
        public double Montante { get; private set; }

        public virtual int PrazoPagamento { get; set; }

        public double JurosAnual { get; private set; }

        public Financiamento(double montante, int prazoPagamento, double jurosAnual)
        {
            Montante = montante;
            PrazoPagamento = prazoPagamento;
            JurosAnual = jurosAnual;
        }

        public override string ToString()
        {
            return $"Prestações de {ValorPrestacao():F2} euros com prazo de pagamento de {PrazoPagamento} meses.";
        }
        public abstract double ValorPrestacao();
    }
}