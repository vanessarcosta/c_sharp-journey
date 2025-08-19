namespace Heights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            double total = 0.0, averageHeights, percentageUnder16;

            Console.Write("Quantos pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            double[] heights = new double[N];
            int[] ages = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Dados da {i + 1}a pessoa:");
                Console.Write("Nome: ");
                names[i] = Console.ReadLine();
                Console.Write("Idade: ");
                ages[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                heights[i] = double.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < N; i++)
            {
                total += heights[i];
                
            }

            averageHeights = total / N;
            Console.WriteLine($"\nAltura media: {averageHeights:F2}");

            total = 0.0;

            for (int i = 0; i < N; i++)
            {
                if (ages[i] < 16)
                {
                    total++;
                }
            }

            percentageUnder16 = 100.0 * total / N;
            Console.WriteLine($"Pessoas com menos de 16 anos: {percentageUnder16:F1}%");

            for (int i = 0; i < N; i++)
            {
                if (ages[i] < 16)
                {
                    Console.WriteLine(names[i]);
                }
            }

        }
    }
}
