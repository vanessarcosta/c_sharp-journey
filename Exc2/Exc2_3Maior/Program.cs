namespace Exc2_3Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.Write("Insira o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"O {numero1} é maior!");
            }
            else
            {
                Console.WriteLine($"O {numero2} é maior!");
            }
        }
    }
}
