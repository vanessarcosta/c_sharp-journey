namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que pede o primeiro nome e o apelido e efetua a saudação

            string primeiroNome, apelido;

            Console.Write("Insira o seu primeiro nome:");
            primeiroNome = Console.ReadLine();

            Console.Write("\n\n\nInsira o seu apelido:");
            apelido = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Olá, {primeiroNome} {apelido}, bem vindo!");                

        }
    }
}
