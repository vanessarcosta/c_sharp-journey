using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Exc10Tartaruga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = 0, dias = 0;

            do
            {
                dias += 1;
                altura++;
            }
            while (altura <= 30);

            Console.WriteLine($"A tartaruga vai gastar {dias} dias para alcançar 30 m.");

        }
    }
}
