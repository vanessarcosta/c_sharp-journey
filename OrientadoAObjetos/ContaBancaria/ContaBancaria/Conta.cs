using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        public int Numero {get; private set;}
        public double DepositoInicial { get; private set;}
        public double Saldo {get; private set;}

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

        #region Methods
        #endregion
    }
}
