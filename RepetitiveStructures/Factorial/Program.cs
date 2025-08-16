namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, factorial;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"FATORIAL = {factorial}" );

        }
    }
}
