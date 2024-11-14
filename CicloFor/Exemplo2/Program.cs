namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, apelido;

            for (int i = 1; i <= 5; i++)
            {
                //corpo do ciclo
                Console.Write($"Insira o nome {i}: ");
                nome = Console.ReadLine();

                Console.Write($"Insira o apelido {i}: ");
                apelido = Console.ReadLine();

                Console.WriteLine($"Olá, {nome} {apelido}");

            }
        }
    }
}
