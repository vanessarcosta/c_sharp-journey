namespace Exc7Expressoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular várias expressões

            double a, b, c, d, resultado;

            Console.WriteLine("Digite os valores de A, B, C e D: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());

            resultado = 2 * b;
            Console.WriteLine($"\n\nO resultado de 2B = {Math.Round(resultado,2)}");

            resultado = (3 * Math.Pow(c, 2) * 4);
            Console.WriteLine($"\nO resultado de 3C^2(9-5) = {Math.Round(resultado, 2)}");

            resultado = ((2 * c) + Math.Pow(b, 2) / (3 * d));
            Console.WriteLine($"\nO resultado de 2C+B^2/3D = {Math.Round(resultado, 2)}");

            resultado = 3 * a * c * 31;
            Console.WriteLine($"\n\nO resultado de 3AC(25+6) = {Math.Round(resultado, 2)}");

        }
    }
}
