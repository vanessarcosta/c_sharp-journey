namespace Exc6Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade, repetidos;
            do
            {
                Console.Write("Qual o tamanho do vetor: ");
            }
            while (!int.TryParse(Console.ReadLine(), out quantidade)); 

            int[] numeros = new int[quantidade];
            bool[] numerosRecebidos = new bool[quantidade];

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.Write($"Insira o número {i + 1}: ");
                }
                while (!int.TryParse(Console.ReadLine(), out numeros[i]));
            }

            for (int i = 0; i < quantidade; i++)
            {
                if (!numerosRecebidos[i])
                {
                    repetidos = 1;

                    for (int j = i + 1; j < quantidade; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            repetidos++;
                            numerosRecebidos[j] = true;
                        }
                    }

                    numerosRecebidos[i] = true; 

                    if (repetidos >= 2)
                    {
                        Console.WriteLine($"{numeros[i]} ocorre {repetidos} vezes");
                    }
                }
            }
        }
    }
}
