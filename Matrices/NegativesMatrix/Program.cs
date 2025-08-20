namespace NegativesMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N, quantity = 0;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            N = int.Parse(Console.ReadLine());

            int [,] matrix = new int[M,N] ;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        Console.WriteLine(matrix[i,j]);
                    }
                }
            }
        }
    }
}
