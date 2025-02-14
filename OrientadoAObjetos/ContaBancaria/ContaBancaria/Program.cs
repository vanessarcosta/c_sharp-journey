using System.Globalization;
using ContaBancaria;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta conta =new Conta();

            Console.Write("Entre o número da conta: ");
            conta.Numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Haverá depósito incial (s/n)? ");
            char escolhaDepositoIncial = char.Parse(Console.ReadLine());

            if (escolhaDepositoIncial == 's' || escolhaDepositoIncial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.RealizarDeposito(depositoInicial);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);  //   Console.WriteLine(conta.ToString()); mesma forma 

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarDeposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RealizarSaque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta.ToString());



        }
    }
}
