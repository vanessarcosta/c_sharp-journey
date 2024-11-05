namespace Exc3_4FormaDePagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double preco = 0;

            Console.WriteLine("Forma de Pagamento            Código      Desconto");
            Console.WriteLine("Pronto Pagamento                 1             30%");
            Console.WriteLine("2 Prestações                     2             20%");
            Console.WriteLine("3 Prestações                     3             10%");
            Console.WriteLine("Entre 4 e 6 prestações           4    Sem Desconto");  

            Console.Write("\nInsira o preço do produto: ");
            preco= Convert.ToDouble(Console.ReadLine());
            Console.Write("Código da forma de pagamento: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    preco -= (preco * 0.3);
                    Console.Write($"Valor a pagar {preco} ");
                    break;
                case 2:
                    preco -= (preco * 0.2);
                    break;
                case 3:
                    preco -= (preco * 0.1);
                    break;
                case 4:

                    break;
            }

            Console.Write($"Valor a pagar {preco} ");
        }
    }
    
}
