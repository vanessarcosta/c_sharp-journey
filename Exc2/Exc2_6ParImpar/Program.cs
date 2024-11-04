namespace Exc2_6ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Insira um número: ");
            numero = Convert.ToDouble(Console.ReadLine());


            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero par.");
            }
            else
            {
                Console.WriteLine("Numero impar.");
            }
        }
    }
}
