
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

        static void  CalculaRaiz(int Inf, int Sup)
        {
            double aux = Inf +1, raiz = 0.0;
            for (int i = Inf +1; i < Sup; i++)
            {
                raiz = Math.Sqrt(aux);
                Console.WriteLine($"A raiz quadrada de {aux} = {raiz:N2}.");
                aux++;
            }

        }

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
