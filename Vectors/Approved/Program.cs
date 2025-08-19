namespace Approved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, i = 0;
            double average;

            Console.Write("Quantas alunos serao digitados? ");
            N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            double[] grades1 = new double[N];
            double[] grades2 = new double[N];

            for (i = 0; i < N; i++)
            {
                Console.WriteLine($"Digite nome, primeira e segunda nota do {i + 1}o aluno:" );
                names[i] = Console.ReadLine();
                grades1[i] = double.Parse(Console.ReadLine());
                grades2[i] = double.Parse(Console.ReadLine());

            }

            average = 0;

            Console.WriteLine("Alunos aprovados:");

            for (i = 0; i < N; i++)
            {
                average =  (grades1[i] + grades2[i]) / 2;
                if (average >= 6.0)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
