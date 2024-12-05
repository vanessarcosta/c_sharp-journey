using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Exc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoArray = TamanhoDoArray();
                        
            string[] nome = new string[tamanhoDoArray];

            PreencheArray(nome);
            Console.WriteLine($"Quantidades de nomes que começam por A, B ou C: {ProcuraNome(nome)}");
        }

        static int ProcuraNome(string[] nome)
        {
            int quantidadeNomes = 0;
            char[] charDoNome = new char[20];
            
            for (int i = 0; i < nome.Length; i++)
            {
                charDoNome = nome[i].ToCharArray();

                if ((charDoNome[0] == 'A') || (charDoNome[0] == 'B') || (charDoNome[0] == 'C'))
                    quantidadeNomes++;
            }
                 return quantidadeNomes;
        }

        static void PreencheArray(string[] nome)
        {
            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nome[i] = Console.ReadLine();
            }
        }

        static int TamanhoDoArray()
        {
            int numero;
            do
            {
                Console.Write("Quantos nomes deseja digitar?");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }
    }
}
