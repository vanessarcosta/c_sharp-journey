using System;

namespace Exc2_5MenorDeTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("Insira o primeiro valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine($"Menor número = {num1}");
            }
            else if (num2 < num1 && num2 < num3)
                Console.WriteLine($"Menor número = {num2}");
            else
                {
                Console.WriteLine($"Menor número = {num3}");
            }            
        }
    }
}
