using System.Globalization;

namespace Exc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, apelido;

            Console.Write("Insira o primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira o apelido: ");
            apelido = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Olá, {nome} {apelido}. Como vai? ");

        }
    }
}
