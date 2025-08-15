namespace ChangeVerified
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, money, change;
            int quantity;

            Console.Write("Preco unitario do produto: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            money = double.Parse(Console.ReadLine());

            change = money - price * quantity;

            if (change >= 0)
            {
                Console.WriteLine($"TROCO = {change:F2}");
            }
            else
            {
                Console.WriteLine($"DINHEIRO INSUFICIENTE. FALTAM {-1 * change} REAIS ");
            }

        }
    }
}
