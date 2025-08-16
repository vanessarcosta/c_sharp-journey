namespace Increasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Digite dois numeros:");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            while (number1 != number2)
            {
                if (number1 > number2)
                {
                    Console.WriteLine("Decrescente!");
                }
                else
                {
                    Console.WriteLine("Crescente!");
                }
                Console.WriteLine("Digite dois numeros:");
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
