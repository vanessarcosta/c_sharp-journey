using System.Runtime.Intrinsics.X86;

namespace Exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteInferior, limiteSuperior;
            limiteInferior = PedirNumero();
            limiteSuperior = PedirNumero();

            for (; limiteInferior <= limiteSuperior; limiteInferior++)
            {
                Console.WriteLine($"A raiz quadrada de {limiteInferior} = {CalculaRaiz(limiteInferior):N2}.");
            }
        }
        /// <summary>
        /// Calcula a raiz quadrada
        /// </summary>
        /// <param name="numero">Radicando da raiz</param>
        /// <returns>raiz</returns>
        static double CalculaRaiz(int radicando)
        {
            double raiz = Math.Sqrt(radicando);
            return raiz; 
        }

        /// <summary>
        /// Pede o  número do intervalo
        /// </summary>
        /// <returns>número inteiro</returns>
        static int PedirNumero()
        {
            int numero;

            do
            {
                Console.Write("Insira um número: ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

    }
}
