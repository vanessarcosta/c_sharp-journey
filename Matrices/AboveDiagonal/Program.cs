
namespace AboveDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, sum = 0;

            Console.WriteLine("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int [,] matrix = new int [N,N] ;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i < j)
                    {
                        sum += matrix[i,j];
                    }
                }
            }

            Console.WriteLine($"SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = {sum}");
        }
    }
}
