using Microsoft.Win32;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int .Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Estudante(name, email);
               
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
           
            for (int i = 0;i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine(i + ": " + quartos[i]);
            }                        
            
        }
    }
}
