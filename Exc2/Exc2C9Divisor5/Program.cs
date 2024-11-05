using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace Exc2C9Divisor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());         

            if (numero % 5 == 0)
            {
                Console.WriteLine($"O número {numero} é divísivel por 5");
            }
            else
            {
                Console.WriteLine($"O número {numero} não é divísivel por 5");
            }            
        }
    }
}
