namespace Exc4_5Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;

            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out x);

            Console.Clear();
            while (y <= 9)
            {
                y++;
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
        }
    }
}
