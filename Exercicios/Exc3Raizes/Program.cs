namespace Exc3Raizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, primeiraRaiz, segundaRaiz;

            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            primeiraRaiz = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            segundaRaiz = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            Console.Write($"As raizes da equação são: {primeiraRaiz}, {segundaRaiz}");
        }
    }
}
