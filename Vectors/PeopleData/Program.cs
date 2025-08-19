namespace PeopleData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, position, older, men, women, i = 0;
            double smaller, taller, average, total;

            Console.Write("Quantas pessoas voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            char[] gender = new char[N];
            double[] height = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.Write($"Altura da {i + 1}a pessoa: " );
                height[i] = double.Parse(Console.ReadLine());
                Console.Write($"Genero da {i + 1}a pessoa: ");
                gender[i] = char.Parse(Console.ReadLine());
            }

            smaller = height[0];
            taller = height[0];
            average = 0.0;
            men = 0;
            women = 0;
            total = 0.0;

            for (i = 0; i < N; i++)
            {
                if (gender[i] == 'F')
                {
                    total += height[i];
                    women++;
                }
                else
                {
                    men++;
                }
            }

            for (i = 1; i < N; i++)
            {
                if (height[i] > taller)
                {
                    taller = height[i];
                }
            }

            for (i = 1; i < N; i++)
            {
                if (height[i] < smaller)
                {
                    smaller = height[i];
                }
            }

            average = total / women;

            Console.WriteLine($"Menor altura = {smaller:F2}");
            Console.WriteLine($"Maior altura = {taller:F2}");
            Console.WriteLine($"Media das alturas das mulheres = {average:F2}");
            Console.WriteLine($"Numero de homens = {men}" );
        }
    }
}
