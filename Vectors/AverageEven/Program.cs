namespace AverageEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, total, count = 0;
            double average;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] vectorNumbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vectorNumbers[i] = int.Parse(Console.ReadLine());
            }

            total = 0;
            for (int i = 0; i < N; i++)
            {
                if (vectorNumbers[i] % 2 == 0)
                {
                    total += vectorNumbers[i];
                    count++;
                }
            }

            if (total == 0)
            {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else
            {
                average = (double)total / count;
                Console.WriteLine($"MEDIA DOS PARES = {average:F1}");
            }

        }
    }
}
