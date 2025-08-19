namespace BelowAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double average, total = 0.0;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            double[] vectorNumbers = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vectorNumbers[i] = double.Parse(Console.ReadLine());
            }


            for (int i = 0; i < N; i++)
            {
                total += vectorNumbers[i];
            }

            average = (double)total / N;
            Console.WriteLine($"\nMEDIA DO VETOR = {average:F3}");

            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");
            for (int i = 0; i < N; i++)
            {
                if (vectorNumbers[i] < average)
                {
                    Console.WriteLine(vectorNumbers[i]);
                }
            }
        }
    }
}
