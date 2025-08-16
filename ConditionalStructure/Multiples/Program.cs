namespace Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Digite dois numeros inteiros:");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            if (number1 % number2 == 0 || number2 % number1 == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }

        }
    }
}
