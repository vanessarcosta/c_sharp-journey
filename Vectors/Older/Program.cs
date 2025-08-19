namespace Older
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, position, older, i = 0;

            Console.WriteLine("Quantas pessoas voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            int[] ages = new int[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:" );
                Console.Write("Nome: ");
                names[i] = Console.ReadLine();
                Console.Write("Idade: ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            older = 0;
            position = 0;

            for (i = 0; i < N; i++)
            {
                if (older < ages[i])
                {
                    older = ages[i];
                    position = i;
                }
            }

            for (i = 0; i < N; i++)
            {
                if (position == i)
                {
                    Console.WriteLine($"PESSOA MAIS VELHA: {names[i]}" );
                }
            }
        }
    }
}
