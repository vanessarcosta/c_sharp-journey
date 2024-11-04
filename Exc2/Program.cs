namespace Exc2._1Positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Insira um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine($"O {numero} é positivo!");
            }
            else
            {
                Console.WriteLine($"O {numero} é negativo!");
            }

        }
    }
}
