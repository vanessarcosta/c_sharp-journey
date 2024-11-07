namespace Exc4_6Somatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, aux = 0;

            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out numero2);

            do
            {
                numero1++;
                aux += numero1;                
            }
            while (numero1 < numero2 - 1);
            Console.WriteLine($"Somatório do intervalo = {aux}");

        }
    }
}
