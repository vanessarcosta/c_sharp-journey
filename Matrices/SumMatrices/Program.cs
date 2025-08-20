namespace SumMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N, quantity = 0;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matrixA = new int [M,N];
            int[,] matrixB = new int[M, N];
            int[,] matrixC = new int[M, N];

            Console.WriteLine("Digite os valores da matriz A:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrixA[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Digite os valores da matriz B:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrixC[i,j] = matrixA[i,j] + matrixB[i,j];
                }
            }

            Console.WriteLine("MATRIZ SOMA:");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrixC[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
