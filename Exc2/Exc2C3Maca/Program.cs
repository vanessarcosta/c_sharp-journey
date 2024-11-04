namespace Exc2C3Maca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, quantidade;

            Console.WriteLine("Insira a quantidade de maças: ");
            quantidade = Convert.ToDouble(Console.ReadLine());
           
            if (quantidade < 12.0)
            {
                preco = quantidade * 0.3;
                Console.WriteLine($"\nValor a pagar: {Math.Round(preco, 2)}");
            }
            else if (quantidade >= 12)
            {
                preco = quantidade * 0.25;
                Console.WriteLine($"\nValor a pagar {Math.Round(preco, 2)}");
            }
        }
    }
}
