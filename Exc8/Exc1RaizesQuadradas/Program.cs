
namespace Exc1RaizesQuadradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Inf, Sup;
            Inf = PedirNumeroInf();
            Sup = PedirNumeroSup();

            CalculaRaiz(Inf, Sup);  
                      
        }
        /// <summary>
        /// Calcula e imprime a raiz dentro de um intervalo
        /// </summary>
        /// <param name="Inf">Limite inferior do intervalo</param>
        /// <param name="Sup">Limite superior do intervalo</param>
        static void  CalculaRaiz(int Inf, int Sup)
        {
            double raiz = 0.0;
            for (Inf += 1; Inf < Sup; Inf++)
            {
                raiz = Math.Sqrt(Inf);
                Console.WriteLine($"A raiz quadrada de {Inf} = {raiz:N2}.");
            }

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
