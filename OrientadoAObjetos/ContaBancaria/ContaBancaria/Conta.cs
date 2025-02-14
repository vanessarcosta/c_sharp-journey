using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo {get; private set;}
        public double TaxaDeSaque  { get;}

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
            Numero = Numero;
            Titular = titular;
            TaxaDeSaque = 5.00;
            Saldo = 0.00;  //inicia por padrão em 0
        }

        public Conta(int numero, string titular, double depositoIncial, double taxaDeSaque) 
        {
            RealizarDeposito(depositoIncial);
          //  Saldo = depositoIncial; mellhor colocar o método e não fazer atribuição direta(se mudar o método para depósito atualiza junto tbm
        }
        #region Methods
        public void AlterarNome(string titularAtualizado)
        {
            Titular = titularAtualizado;
        }

        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
        }

        public void RealizarSaque(double valor)
        {
            Saldo -=  valor + TaxaDeSaque;
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
