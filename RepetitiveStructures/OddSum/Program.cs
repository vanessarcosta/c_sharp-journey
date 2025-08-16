namespace OddSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddSum, number1, number2, aux;

            Console.WriteLine("Digite dois numeros:");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                aux = number1;
                number1 = number2;
                number2 = aux;
            }

            oddSum = 0;

            for (int i = number1 + 1; i < number2; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum = oddSum + i;
                }

            }

            Console.WriteLine($"SOMA DOS IMPARES = {oddSum}" );
        }
    }
}
