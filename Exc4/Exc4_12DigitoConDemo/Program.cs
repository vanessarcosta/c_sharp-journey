namespace Exc4_12DigitoConDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, numero, dig = 1, total = 0, nat = 1, checkDigito = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Insira um número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            n = numero;

            while( n > 0)
            {
                dig = n % 10;
                total += dig * nat;
                n /= 10;
                nat++;
            }

            checkDigito = total % 7;

            Console.WriteLine($"O código com digito de controlo é {numero}{checkDigito}.");
        }
    }
}
