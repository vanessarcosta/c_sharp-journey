namespace Exc1RaizesQuadradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Inf, Sup;

            Inf = PedirNumeroInf();
            Sup = PedirNumeroSup();
        }

        static int PedirNumeroSup()
        {
            int numero;

            do
            {
                Console.Write("Insira o primeiro número: ");
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
