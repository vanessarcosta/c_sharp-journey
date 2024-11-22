namespace Exc4_5Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;

            do
            {
                do
                {
                    Console.WriteLine("Digite um número inteiro entre 1 e 10: ");
                }
                while (!int.TryParse(Console.ReadLine(), out x));
            }
            while (x < 1 || x > 10);
            
            Console.Clear();
            while (y <= 9)
            {
                y++;
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
        }
    }
}
