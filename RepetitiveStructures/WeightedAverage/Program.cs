namespace WeightedAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, average;
            int quantity;

            Console.Write("Quantos casos voce vai digitar? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Digite tres numeros:");
                number1 = double.Parse(Console.ReadLine());
                number2 = double.Parse(Console.ReadLine());
                number3 = double.Parse(Console.ReadLine());

                average = ((number1 * 2.0) + (number2 * 3.0) + (number3 * 5.0)) / 10.0;
                Console.WriteLine($"MEDIA = {average:F1}");
            }
        }
    }
}
