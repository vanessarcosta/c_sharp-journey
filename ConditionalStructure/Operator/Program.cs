namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double plan = 50.0, valuePerMinute = 2.0, total;            
            int minutes;

            Console.Write("Digite a quantidade de minutos:");
            minutes = int.Parse(Console.ReadLine());

            if (minutes > 100)
            {
                plan = (minutes - 100) * valuePerMinute + plan;
            }

            Console.WriteLine($"Valor a pagar: R$ {plan}");
        }
    }
}
