namespace Baskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Esta equacao nao possui raizes reais.");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1:F4}");

                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x2:F4}");
            }
        }
    }
}
