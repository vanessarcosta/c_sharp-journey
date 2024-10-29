using System;

namespace Exc5Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a área e perimetro do retângulo

            double C, L;

            Console.Write("Informe o comprimento do retângulo: ");
            C = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a largura do retângulo: ");
            L = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nA área do retângulo é = {Math.Round (C * L,2)} ");
            Console.WriteLine($"O perímetro do retângulo é = {Math.Round (2 * C + 2* L,2)} ");

        }
    }
}
