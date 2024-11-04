using System;
using System.ComponentModel.Design;

namespace Exc2_8_PrecoCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoCerto, precoA, precoB, precoC;
            double diferencaA =0.0, diferencaB = 0.0, diferencaC =0.0;

            Console.Write("Preço Certo: ");
            precoCerto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Preço do concorrente A: ");
            precoA = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Preço do concorrente B: ");
            precoB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Preço do concorrente C: ");
            precoC = Convert.ToDouble(Console.ReadLine());

            if (precoA > precoCerto && precoB > precoCerto && precoC > precoCerto)
            {
                Console.WriteLine("Nenhum concorrente ganhou!");
            }
            else
            {
                diferencaA = precoCerto - precoA;
                diferencaB = precoCerto - precoB;
                diferencaC = precoCerto - precoC;

                if (precoA <= precoCerto && diferencaA < diferencaB && diferencaA < diferencaC)
                {
                    Console.WriteLine("Ganhou o concorrente A");
                }
                else if (precoB <= precoCerto && diferencaB < diferencaC)
                {
                    Console.WriteLine("Ganhou o concorrente B");
                }
                else
                {
                    Console.WriteLine("Ganhou o concorrente C");
                }
            }
        }
    }
}
