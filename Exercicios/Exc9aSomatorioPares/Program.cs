using System.Runtime.Intrinsics.X86;

namespace Exc9aSomatorioPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, somatorio = 0;
            do
            {
                if (numero % 2.0 == 0)
                {
                    somatorio += numero;
                }
                numero++;
            }
            while (numero < 20);
            Console.WriteLine($"Somatório do números pares do intervalo 0 de até 20 = {somatorio}");
        }
    }
}
