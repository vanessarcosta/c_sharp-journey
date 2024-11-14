namespace Exc5_MultiComDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, adicionay = 0;

            do
            {
                Console.Write("Digite o primeiro valor ");
            }

            while (!int.TryParse(Console.ReadLine(), out x));

            do
            {
                Console.Write("Digite o segundo valor: ");
            }

            while (!int.TryParse(Console.ReadLine(), out y));

            for (int i = 0; x >= 2; i++)
            {
                if (x % 2 != 0 && x != 1)
                {
                    adicionay += y;
                }
                y = y * 2;
                x = x / 2;
            }
            
            Console.WriteLine($"Resultado = {y + adicionay}.");

        }
    }
}
