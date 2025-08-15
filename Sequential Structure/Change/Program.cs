namespace Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price, moneyReceived, change;
            int quantity;

            Console.Write("Preco unitario do produto: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            moneyReceived = double.Parse(Console.ReadLine());

            change = moneyReceived - (price * quantity);
            Console.WriteLine($"TROCO = {change:F2}");

        }
    }
}
