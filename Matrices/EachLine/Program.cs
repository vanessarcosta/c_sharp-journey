namespace EachLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, bigger = 0;

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

            Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA:");

            for (int i = 0; i < N; i++)
            {
                bigger = 0;
                for (int j = 0; j < N; j++)
                {
                    if (bigger < matrix[i,j])
                    {
                        bigger = matrix[i,j];
                    }
                }
                Console.WriteLine(bigger);
            }
        }
    }
}
