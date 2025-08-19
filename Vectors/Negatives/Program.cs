namespace Negatives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            
            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            int[] numbers =  new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS: ");
            for (int i = 0; i < N; i++)
            {
                if (numbers[i] < 0)
                {
                    Console.WriteLine($"{numbers[i]} ");
                }
            }


        }
    }
}
