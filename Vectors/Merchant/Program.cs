namespace Merchant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, profitA = 0, profitB = 0, profitC = 0;
            double profit = 0.0, totalSale = 0.0, totalPurchase = 0.0, totalProfit = 0.0;

            Console.Write("Serao digitados dados de quantos produtos? ");
            N = int.Parse(Console.ReadLine());

            string[] products = new string[N];
            double[] sellingPrice = new double[N];
            double[] buyingPrice = new double[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Produto {i + 1}:" );
                Console.Write("Nome: ");
                products[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                buyingPrice[i] = double.Parse(Console.ReadLine());
                Console.Write("Preco de venda: ");
                sellingPrice[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                profit = (sellingPrice[i] - buyingPrice[i]) * 100 / buyingPrice[i];

                if (profit < 10.0)
                {
                    profitA++;
                }
                else if (profit <= 20.0)
                {
                    profitB++;
                }
                else
                {
                    profitC++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                totalPurchase += buyingPrice[i];
                totalSale += sellingPrice[i];
            }

            totalProfit = totalSale - totalPurchase;

            Console.WriteLine("\nRELATORIO:");
            Console.WriteLine($"Lucro abaixo de 10%%: {profitA}");
            Console.WriteLine($"Lucro entre 10%% e 20%%: {profitB}");
            Console.WriteLine($"Lucro acima de 20%%: {profitC}");
            Console.WriteLine($"Valor total de compra: {totalPurchase:F2}");
            Console.WriteLine($"Valor total de venda: {totalSale:F2}");
            Console.WriteLine($"Lucro total: {totalProfit:F2}");
        }
    }
}
