namespace Glucose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double glucose;

            Console.Write("Digite a medida da glicose: ");
            glucose = double.Parse(Console.ReadLine());

            if (glucose <= 100.0)
            {
                Console.WriteLine("Classificacao: normal\n");
            }
            else if (glucose <= 140.0)
            {
                Console.WriteLine("Classificacao: elevado\n");
            }
            else
            {
                Console.WriteLine("Classificacao: diabetes\n");
            }
        }
    }
}
