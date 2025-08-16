namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, quantity;

            Console.Write("Quantos numeros voce vai digitar?");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write("Digite um numero: ");
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("NULO");
                }
                else if (number % 2 != 0)
                {
                    if (number > 0)
                    {
                        Console.WriteLine( "IMPAR POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR NEGATIVO");
                    }
                }
                else
                {
                    if (number > 0)
                    {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("PAR NEGATIVO");
                    }
                }

            }
        }
    }
}
