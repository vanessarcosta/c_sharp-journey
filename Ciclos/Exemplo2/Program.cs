namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool teste;

            Console.WriteLine("Insira um número");
            //teste = int.TryParse(Console.ReadLine(), out numero);

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Conseguiu converter");
            }
            else
            {
                Console.WriteLine("Não consegiu converter");
            }

            Console.WriteLine(numero);
           // Console.WriteLine(teste);

            //TryParse
        }
    }
}
