namespace Exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;

            Console.Write("Insira o primeiro número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nA soma dos valores digitados:  {numero1} + {numero2} + {numero3} = {numero1 + numero2 +numero3}\n");
           
            Console.WriteLine($"O produto dos valores digitados:  {numero1} * {numero2} * {numero3} = {numero1 * numero2 * numero3}");
        }
    }
}
