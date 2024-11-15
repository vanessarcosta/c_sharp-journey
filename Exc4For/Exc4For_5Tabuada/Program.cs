namespace Exc4For_5Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1;

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out x);

            Console.Clear();
            for (; y <= 10; y++)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
        }
    }
}
