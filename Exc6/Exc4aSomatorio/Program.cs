namespace Exc4aSomatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, soma = 0;
            do
            {
                Console.Write("Qual o tamanho do vetor: ");
            }
            while (!int.TryParse(Console.ReadLine(), out quantidade));

            int[] numeros = new int[quantidade];

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.Write($"Insira o número {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out numeros[i]));
            }

            for (int j = 0; j < numeros.Length; j++)
            {
                soma += numeros[j];
            }

            Console.WriteLine($"O somatório de todos os elementos do array = {soma}");
            Console.WriteLine($"A média do somatório de todos os elementos do array" +
                $"= {soma / quantidade}");

        }
    }
}
