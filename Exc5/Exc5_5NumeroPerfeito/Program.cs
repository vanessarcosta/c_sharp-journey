using System.ComponentModel.Design;

namespace Exc5_5NumeroPerfeito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, divisores = 0;

            do
            {
                Console.Write("Insira um valor: ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores += i;
                }
            }

            if (divisores == numero)
            {
                Console.WriteLine($"O número {numero} é perfeito.");
            }
            else
            {
                Console.WriteLine($"O número {numero}  não é perfeito.");
            }
        }
    }   
}
