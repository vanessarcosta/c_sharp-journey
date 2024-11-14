namespace Exemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 1; j <= 5; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
                
            }
        }
    }
}
