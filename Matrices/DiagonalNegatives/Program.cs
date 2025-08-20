namespace DiagonalNegatives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, quantity = 0;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        quantity++;
                    }
                }
            }

            Console.Write($"\nQUANTIDADE DE NEGATIVOS = {quantity}");
        }
    }
}
