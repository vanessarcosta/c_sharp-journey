namespace InsideOutside
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity, number, inside, outside;

            Console.Write("Quantos numeros voce vai digitar? ");
            quantity = int.Parse(Console.ReadLine());

            inside = 0;
            outside = 0;

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write("Digite um numero: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    inside += 1;
                }
                else
                {
                    outside += 1;
                }

            }

            Console.WriteLine($"{inside} DENTRO" );
            Console.WriteLine($"{outside} FORA" );
        }
    }
}
