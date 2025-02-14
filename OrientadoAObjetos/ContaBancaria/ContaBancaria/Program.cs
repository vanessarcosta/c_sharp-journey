using System.Globalization;
using ContaBancaria;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolhaDepositoIncial;

            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            conta.Numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Haverá depósito incial (s/n)?");
            escolhaDepositoIncial = Console.ReadLine();

            if (escolhaDepositoIncial == "s")
            {
                Console.Write("Entre o valor de depósito incial: ");
                conta.DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.RealizarDeposito(conta.Saldo, conta.DepositoInicial);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta.ToString());

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            conta.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarDeposito(conta.Saldo, conta.Valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            conta.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarSaque(conta.Saldo, conta.Valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());



        }
    }
}
