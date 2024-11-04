namespace Exc2C1Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data;

            Console.WriteLine("Digite o ano de nascimento:");
            data = Convert.ToInt32(Console.ReadLine());

            if (data > 2006)
            {
                Console.WriteLine("Não está apto a votar");
            }
            else
            { 
                Console.WriteLine("Está apto a votar");
            }
        }
    }
}
