using Microsoft.Win32;
using System.Runtime.ConstrainedExecution;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PensionatoService[] quartos = new PensionatoService[9];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int .Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int .Parse(Console.ReadLine());

                quartos[quarto] = new PensionatoService { Name = name, Email = email};
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
           
            for (int i = 0;i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine(i + ": " + quartos[i].Name + ", " + quartos[i].Email);
            }                        
            
        }
    }
}
