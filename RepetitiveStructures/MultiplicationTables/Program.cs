namespace MultiplicationTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, total;

            Console.Write("Deseja a tabuada para qual valor? ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                total = number * i;

                Console.WriteLine($"{number} x {i} = {total}");
            }
        }
    }
}
