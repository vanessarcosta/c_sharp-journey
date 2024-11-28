namespace Exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        Console.Write($"Insira os valores na matriz: ");
                    } while (!int.TryParse(Console.ReadLine(), out numeros[i, j]));
                }
            }

            int maiorElemento = 0;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (numeros[i, j] > maiorElemento)
                        maiorElemento = numeros[i, j];   
                }
            }

            Console.WriteLine("Pressione qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"O maior elemento da matriz é {maiorElemento}");

        }
    }
}
