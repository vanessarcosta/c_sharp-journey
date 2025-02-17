using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFuncionario, segundoFuncionario;

            primeiroFuncionario = new Funcionario();
            segundoFuncionario = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            primeiroFuncionario.nome = Console.ReadLine();
            Console.Write("Salário: ");
            primeiroFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            segundoFuncionario.nome = Console.ReadLine();
            Console.Write("Salário: ");
            segundoFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (primeiroFuncionario.salario + segundoFuncionario.salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
