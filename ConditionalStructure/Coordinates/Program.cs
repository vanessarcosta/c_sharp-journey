namespace Coordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("Valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Valor de Y: ");
            y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if(y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}
