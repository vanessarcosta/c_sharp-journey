namespace OddSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Digite o valor de X: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
