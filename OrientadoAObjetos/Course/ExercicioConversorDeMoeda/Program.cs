using System.Globalization;

namespace ExercicioConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeEmDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double reais = ConversorDeMoeda.ConverterMoeda(cotacaoDolar, quantidadeEmDolares);

            Console.WriteLine("Valor a ser pago em reais = " + reais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
