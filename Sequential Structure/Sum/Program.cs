namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            sum = x + y;

            Console.WriteLine($"SOMA = {sum}");
        }
    }
}
