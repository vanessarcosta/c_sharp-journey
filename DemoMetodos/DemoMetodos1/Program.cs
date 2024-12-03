namespace DemoMetodos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, numero2;
            do
            {
                Console.Write("Insira o número para calcular o cubo: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            Console.WriteLine($"O cubo do {numero} = {calculaCubo(numero)}");

            Console.WriteLine($"O fatorial do {numero} = {calculaFatorial(numero)}");

            do
            {
                Console.Write("Insira o segundo número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero2));

            Console.WriteLine($"O maior ds dois números é o {maior(numero, numero2)}");
        }

        static int maior(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static int calculaCubo(int valor)
        {
            return valor * valor * valor;
            //int n;

           // n= valor * valor * valor;

          //  return n;
        }

        static int calculaFatorial(int n)
        {
            int fat = 1, i = n;
            while (i > 0)
            {
                fat = fat * i;
                i--;
            }
            return fat;
        }
    }
}
