namespace Exc4For_8Combinacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NP, NC, a = 1, b = 1;

            Console.Write("Digite um número de pontos: ");
            int.TryParse(Console.ReadLine(), out NP);
            Console.Write("Digite um número de casas: ");
            int.TryParse(Console.ReadLine(), out NC);


            for (; a <= NP; a++)
            {
                for (global::System.Int32 j = 0; b <= NC; b++)
                {
                    Console.Write($" {a}-{b} \t");
                }
                b = 1;
            }
        }
    }
}
