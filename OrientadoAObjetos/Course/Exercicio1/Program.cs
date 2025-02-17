namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa, segundaPessoa;

            primeiraPessoa = new Pessoa();
            segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pesssoa:");
            Console.Write("Nome: ");
            primeiraPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.idade = int.Parse((Console.ReadLine()));

            Console.WriteLine("Dados da segunda pesssoa: ");
            Console.Write("Nome: ");
            segundaPessoa.nome = Console.ReadLine();
            Console.Write("Idade:");
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.idade > segundaPessoa.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.nome} ");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segundaPessoa.nome}");
            }

        }
    }
}
