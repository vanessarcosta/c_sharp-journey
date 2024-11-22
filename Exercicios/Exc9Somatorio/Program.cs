using System.Runtime.Intrinsics.X86;

namespace Exc9Somatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, somatorio = 0;
            do
            {
                numero++;
                somatorio += numero;
            }
            while (numero < 20);
            Console.WriteLine($"Somatório do intervalo 0 de até 20 = {somatorio}");
        }
    }
}
