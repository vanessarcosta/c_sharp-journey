namespace ConsecutivePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum;

            Console.Write("Digite um numero inteiro: ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number % 2 != 0)
                {
                    number = number + 1;
                }

                sum = 5 * number + 20;

                Console.WriteLine($"SOMA = {sum}");

                Console.Write("Digite um numero inteiro: ");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
