namespace HighestPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, highestPosition;
            double highestValue;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vectorNumbers = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                vectorNumbers[i] = double.Parse(Console.ReadLine());
            }

            highestPosition = 0;
            highestValue = 0;

            for (int i = 0; i < N; i++)
            {
                if (highestValue < vectorNumbers[i])
                {
                    highestValue = vectorNumbers[i];
                    highestPosition = i;
                }
            }

            Console.WriteLine($"\nMAIOR VALOR = {highestValue:F1}");
            Console.WriteLine($"POSICAO DO MAIOR VALOR = {highestPosition}");
        }
    }
}
