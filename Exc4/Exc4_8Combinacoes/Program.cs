namespace Exc4_8Combinacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NP, NC,a = 1, b = 1;

            Console.WriteLine("Digite um número de pontos");
            int.TryParse(Console.ReadLine(), out NP);
            Console.WriteLine("Digite um número de casas");
            int.TryParse(Console.ReadLine(), out NC);

            while (a <= NP)
            {               
                while (b <= NC)
                {                   
                    Console.WriteLine($"{a} - {b}");
                    b++;
                }
                b = 1;
                a++;
            }

        }
    }
}
