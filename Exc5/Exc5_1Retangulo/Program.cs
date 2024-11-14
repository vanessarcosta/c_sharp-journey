namespace Exc5_1Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, comprimento;

            do
            {
                Console.Write("Digite a altura do retângulo: ");
            }

            while (!int.TryParse(Console.ReadLine(), out altura));

            do
            {
                Console.Write("Digite o comprimento do retângulo: ");
            }

            while (!int.TryParse(Console.ReadLine(), out comprimento));

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < comprimento; j++)
                {                   
                        Console.Write($"* ");                    
                }
                Console.WriteLine();

            }
        }
    }
}
