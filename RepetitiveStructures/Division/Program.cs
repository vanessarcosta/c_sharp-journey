namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numerator, denominator, division;
            int quantity;

            Console.Write("Quantos casos voce vai digitar? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write("Entre com o numerador: ");
                numerator = double.Parse(Console.ReadLine());

                Console.Write("Entre com o denominador: ");
                denominator = double.Parse(Console.ReadLine());

                if (denominator != 0)
                {
                    division = numerator / denominator;
                    Console.WriteLine($"DIVISAO = {division:F2}" );
                }
                else
                {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
            }
        }
    }
}
