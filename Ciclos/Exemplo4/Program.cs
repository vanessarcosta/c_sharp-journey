namespace Exemplo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa para pedir ao utilizador um número
            //e mostrar uma listagem dos 20 números seguintes

            int numero, limiteSuperior;

            do
            {
                Console.Write("Insira um número inteiro: ");

            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            limiteSuperior = numero + 20;

            while (numero <= limiteSuperior)
            {
                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}
