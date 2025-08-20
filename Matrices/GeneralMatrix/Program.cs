namespace GeneralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, line, column;
            double sum = 0.0;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            double [,] matrix = new double[N,N] ;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrix[i,j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        sum += matrix[i,j];
                    }
                }
            }
            Console.WriteLine($"\nSOMA DOS POSITIVOS: {sum}");

            Console.Write("\nEscolha uma linha: ");
            line = int.Parse(Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");

            for (int j = 0; j < N; j++)
            {
                Console.Write($"{matrix[line,j]:F1} ");
            }

            Console.Write("\n\nEscolha uma coluna: ");
            column = int.Parse(Console.ReadLine());
            Console.Write("COLUNA ESCOLHIDA: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matrix[i,column]:F1} ");
            }

            Console.Write("\n\nDIAGONAL PRINCIPAL: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matrix[i,j]:F2} ");
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        matrix[i,j] = Math.Pow(matrix[i,j], 2);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nMATRIZ ALTERADA:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i,j]:F1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
