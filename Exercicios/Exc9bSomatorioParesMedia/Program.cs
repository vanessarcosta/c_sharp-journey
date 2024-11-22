namespace Exc9bSomatorioParesMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, somatorio = 0, aux = 0;
            do
            {
                if (numero % 2.0 == 0)
                {
                    somatorio += numero;
                    aux += 1;
                }
                numero++;
            }
            while (numero < 20);
            Console.WriteLine($"Somatório do números pares do intervalo 0 de até 20 = {somatorio / aux}");

        }
    }
}
