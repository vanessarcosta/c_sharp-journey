namespace SumVectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double sum = 0, average;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] numbers = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("\nVALORES = ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{numbers[i]:F2} ");

            }

            for(int i = 0;i < N;i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"\nSOMA = {sum:F2}");

            average = sum / N;
            Console.WriteLine($"MEDIA = {average:F2}");

        }
    }
}
