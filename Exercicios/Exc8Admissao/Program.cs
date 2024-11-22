namespace Exc8Admissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notaFis, notaQui, notaMat, somaTres = 0, somaMatFis = 0;
            
            do
            {
                Console.Write("Digite a nota de Física: ");
            }
            while (!int.TryParse(Console.ReadLine(), out notaFis));

            do
            {
                Console.Write("Digite a nota de Química: ");
            }
            while (!int.TryParse(Console.ReadLine(), out notaQui));

            do
            {
                Console.Write("Digite a nota de Matemática: ");
            }
            while (!int.TryParse(Console.ReadLine(), out notaMat));

            somaTres = notaFis+ notaMat + notaQui;
            somaMatFis = notaMat + notaFis;

            if (notaFis >= 65 && notaFis >=55 && notaQui >= 50 && (somaTres >= 180 || somaMatFis >= 140))
            {
                Console.WriteLine("O candidato foi admitido!");
            }
            else
            {
                Console.WriteLine("O candidato não foi admitido.");
            }

        }
    }
}
