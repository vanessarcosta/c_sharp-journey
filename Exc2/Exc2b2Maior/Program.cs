namespace Exc2b2Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Insira o primeiro valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o terceiro valor: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"Maior número = {num1}");
            }
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"Maior número = {num2}");
            else
            {
                Console.WriteLine($"Maior número = {num3}");
            }
        }
    }
}
