using System.Runtime.Intrinsics.X86;

namespace Exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Inf, Sup;
            Inf = PedirNumeroInf();
            Sup = PedirNumeroSup();

            for (; Inf < Sup-1; Inf++)
            {
                Console.WriteLine($"A raiz quadrada de {Inf+1} = {CalculaRaiz(Inf):N2}.");
            }
        }
        /// <summary>
        /// Calcula a raiz quadrada
        /// </summary>
        /// <param name="Inf">Radicando da raiz</param>
        /// <returns>a raiz double</returns>
        static double CalculaRaiz(int Inf)
        {
            double raiz = Math.Sqrt(Inf+1);
            return raiz; 
        }
        /// <summary>
        /// Pede o segundo número do intervalo
        /// </summary>
        /// <returns>o segundo inteiro</returns>
        static int PedirNumeroSup()
        {
            int numero;

            do
            {
                Console.Write("Insira o segundo número: ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }
        /// <summary>
        /// Pede o primeiro número do intervalo
        /// </summary>
        /// <returns>o primeiro inteiro</returns>
        static int PedirNumeroInf()
        {
            int numero;

            do
            {
                Console.Write("Insira o primeiro número: ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

    }
}
