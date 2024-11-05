namespace Exc2C7Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
           
            Console.Write("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
                        
            if (idade >= 18 && idade <=67)
            {
                Console.WriteLine("Apto a fazer a doação de sangue.");
            }
            else
            {                
                Console.WriteLine("Apto a fazer a doação de sangue.");
            }
        }
    }
}
