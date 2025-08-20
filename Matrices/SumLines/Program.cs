namespace SumLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            double sumLines = 0;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            N = int.Parse(Console.ReadLine());

            double[,] matrix = new double[M,N];
            double [] vectorSum = new double[M];

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"Digite os elementos da  {i + 1}a. linha:");

                for (int j = 0; j < N; j++)
                {
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < M; i++)
            {
                sumLines = 0;
                for (int j = 0; j < N; j++)
                {
                    sumLines += matrix[i,j];
                }
                vectorSum[i] = sumLines;
            }

            Console.WriteLine("VETOR GERADO:");

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine($"{vectorSum[i]:F1}");
            }
        }
    }
}
