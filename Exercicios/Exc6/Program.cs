namespace Exc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto, prestacao, prestacaoMaxima = 0;

            do
            {
                Console.Write("Digite o salario bruto: ");
            }
            while (!double.TryParse(Console.ReadLine(), out salarioBruto));

            do
            {
                Console.Write("Digite o valor da prestação pretendida: ");
            }
            while (!double.TryParse(Console.ReadLine(), out prestacao));

            prestacaoMaxima = salarioBruto * 0.3;

            if (prestacao <= prestacaoMaxima)
            {
                Console.WriteLine($"O crédito concedido.");
            }
            else
            {
                Console.WriteLine("O crédito não pode ser concedido.");
            }
        }
    }
}
