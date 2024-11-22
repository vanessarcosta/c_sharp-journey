namespace Exc4FuncaoX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Digite o valor de x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x <= 1)
            {
                x = 1;
            }
            else if (x <= 2)
            {
                x = 2;
            }
            else if (x <= 3)
            {
                x = x * x;
            }
            else
            {
                x = x * x * x;
            }

            Console.Write($"O valor de f(x) = {x}");
        }
    }
}
