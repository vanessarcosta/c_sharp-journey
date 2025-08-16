namespace Experiences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, quantity, S, R, C, total;
            char testSubject;

            Console.Write("Quantos casos de teste serao digitados? ");
            N = int.Parse(Console.ReadLine());

            S = 0;
            R = 0;
            C = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                quantity = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                testSubject = char.Parse(Console.ReadLine());

                switch (testSubject)
                {
                    case 'S':
                        S += quantity;
                        break;
                    case 'R':
                        R += quantity;
                        break;
                    case 'C':
                        C += quantity;
                        break;
                }
            }

            total = S + R + C;
            Console.WriteLine("\nRELATORIO FINAL:");
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {C}");
            Console.WriteLine($"Total de ratos: {R}");
            Console.WriteLine($"Total de sapos: {S}");
            Console.WriteLine($"Percentual de coelhos: {(double)C * 100 / total:F2}");
            Console.WriteLine($"Percentual de ratos: {(double)R * 100 / total:F2}");
            Console.WriteLine($"Percentual de sapos: {(double)S * 100 / total:F2}");
        }
    }
}
