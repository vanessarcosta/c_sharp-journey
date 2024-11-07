namespace Exemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Insira um número: ");
                 
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            Console.WriteLine("Saiu do ciclo");
        }
    }
}
