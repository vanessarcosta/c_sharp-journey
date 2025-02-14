using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero {get; }
        public double DepositoInicial { get; private set;}
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
                if (titular != null && value.Length > 1)
                { titular = value; }
            }
        }
        public Conta() 
        {
            TaxaDeSaque = 5.00;
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
            Saldo = saldoAnterior - valor;
            return Saldo - TaxaDeSaque;
        }
        public override string ToString()
        {
            return "Conta " + Numero
                + ", Titular: " + Titular 
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture;
        }
        #endregion
    }
}
