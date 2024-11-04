namespace Exc2C2Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.WriteLine("Digite a senha: ");
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 1234) 
            {
                Console.WriteLine("Senha Inválida! Tente novamente.");                
                Console.WriteLine("Digite a senha: ");                
                senha = Convert.ToInt32(Console.ReadLine());         
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}
