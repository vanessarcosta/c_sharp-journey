namespace Exc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N, A = 0;
            int aux = 1;

            do
            {
                Console.Write("Insira o valor de N: ");
            } while (!double.TryParse(Console.ReadLine(), out N));

            while (N >= 1)
            {
                A = A + N / aux;
                aux++;
                N--;
            }

            A = A + N / aux;

            Console.Write($"A possui o valor: {A}");
        }
    }
}
