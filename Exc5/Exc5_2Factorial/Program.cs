namespace Exc5_2Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial = 1;

            do
            {
                Console.Write("Digite a altura do retângulo: ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            for (int i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine($"Fatorial de {numero} = {fatorial}");
        }
    }
}
