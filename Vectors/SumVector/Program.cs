namespace SumVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Quantos valores vai ter cada vetorr? ");
            N = int.Parse(Console.ReadLine());

            int[] vectorA = new int[N];
            int[] vectorB = new int[N];
            int[] vectorC = new int[N];

            Console.WriteLine("Digite os valores do vetor A:");

            for (int i = 0; i < N; i++)
            {
                vectorA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");

            for (int i = 0; i < N; i++)
            {
                vectorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                vectorC[i] = vectorA[i] + vectorB[i];
            }

            Console.WriteLine("VETOR RESULTANTE:");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vectorC[i]);
            }
        }
    }
}
