namespace Exc4_12DigitoDeControle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            string numeroStr = numero.ToString();

        }
    }
}
