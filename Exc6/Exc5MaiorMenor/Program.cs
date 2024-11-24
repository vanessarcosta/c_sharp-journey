namespace Exc5MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
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

            int maiorElemento = numeros[0], menorElemento = numeros[0];

            for (int j = 0; j < numeros.Length; j++)
            {
                if (numeros[j] > maiorElemento)
                    maiorElemento = numeros[j];

                if (numeros[j] < menorElemento)
                    menorElemento = numeros[j];

            }

            Console.WriteLine($"O maior elementos do array = {maiorElemento}");
            Console.WriteLine($"O menor elementos do array = {menorElemento}");

        }
    }
}
