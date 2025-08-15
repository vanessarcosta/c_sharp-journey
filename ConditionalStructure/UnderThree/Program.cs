namespace UnderThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, smaller;

            Console.Write("Primeiro valor: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            number3 = int.Parse(Console.ReadLine());

            if(number1 < number2 && number1 < number3)
            {
                smaller = number1;
            }
            else if(number2 < number3)
            { 
                smaller = number2;
            }
            else
            {
                smaller = number3;
            }

            Console.WriteLine($"MENOR = {smaller}");

        }
    }
}
