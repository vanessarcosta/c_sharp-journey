namespace Exc1LerVetor
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
                while (!int.TryParse(Console.ReadLine(),out numeros[i]));
            }
        }
    }
}
