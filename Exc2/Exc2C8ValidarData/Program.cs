namespace Exc2C8ValidarData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.Write("Digite o dia de nascimento: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if (dia <= 0 || dia > 31)
            {
                Console.WriteLine($"Valor {dia} informado não representa uma data válida.Digite valor entre 1 e 31");
            }
            else if (mes <= 0 || mes > 12)
            {
                Console.WriteLine($"Valor {mes} informado não representa uma data válida. Digite valor entre 1 e 12.");
            }
            else if (ano > 2024)
            {
                Console.WriteLine($"Valor {ano} informado não representa uma data válida.Digite valor menor 2024");
            }
        }
    }
}
