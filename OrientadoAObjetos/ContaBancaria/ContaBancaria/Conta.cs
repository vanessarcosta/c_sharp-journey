using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; set; }
        public double DepositoInicial { get; set;}
        public double Saldo {get; private set;}
        public double TaxaDeSaque  { get; }
        public double Valor { get; set; }

        string titular;
        public string Titular
        {
            get
            {
                return titular;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 1)
                 titular = value;
            }
        }
        public Conta() 
        {
            TaxaDeSaque = 5.00;
            Saldo = 0.00;
        }

        public Conta(int numero, string titular, double depositoIncial, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = depositoIncial;
            TaxaDeSaque = 5.00;
        }
        #region Methods
        public void AlterarNome(string titularAtualizado)
        {
            Titular = titularAtualizado;
        }

        public void RealizarDeposito(double saldoAnterior, double valor)
        {
            Saldo = saldoAnterior + valor;
        }

        public double RealizarSaque(double saldoAnterior, double valor)
        {
            Saldo = saldoAnterior - valor - TaxaDeSaque;
            return Saldo;
        }
        public override string ToString()
        {
            return "Conta " + Numero
                + ", Titular: "
                + Titular 
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
