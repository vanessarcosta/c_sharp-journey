namespace FixedPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password;

            Console.Write("Digite a senha: ");
            password = int.Parse(Console.ReadLine());

            while (password != 2002)
            {
                Console.Write("Senha invalida! Tente novamente: ");
                password = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
        }
    }
}
