namespace Cafeteria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int quantity, product;
            double total = 0;

            Console.Write("Codigo do produto comprado: ");
            product = int.Parse(Console.ReadLine());

            Console.Write("Quantidade comprada: ");
            quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case 1:
                    total = 5.00 * quantity;
                    break;
                case 2:
                    total = 3.50 * quantity;
                    break;
                case 3:
                    total = 4.80 * quantity;
                    break;
                case 4:
                    total = 8.90 * quantity;
                    break;
                case 5:
                    total = 7.32 * quantity;
                    break;

            }

            Console.WriteLine($"Valor a pagar: R$ {total:F2}");
        }
    }
}
