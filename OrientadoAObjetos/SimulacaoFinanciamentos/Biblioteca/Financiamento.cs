namespace Biblioteca
{
    public abstract class Financiamento
    {
        public double Montante { get; private set; }

        public abstract int PrazoPagamento { get; set; }

        public double JurosAnual { get; private set; }

        public Financiamento(double montante, double jurosAnual)
        {
            Montante = montante;
            JurosAnual = jurosAnual;
        }

        public override string ToString()
        {
            return $"Prestações de {ValorPrestacao():F2} euros com prazo de pagamento de {PrazoPagamento} meses.";
        }
        public abstract double ValorPrestacao();
    }
}