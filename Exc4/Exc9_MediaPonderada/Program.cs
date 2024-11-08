namespace Exc9_MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;
            double nota1, nota2, nota3, media = 0.0;

            Console.Write("Digite o código do aluno: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.WriteLine("Digite as três notas: ");
            double.TryParse(Console.ReadLine(), out nota1);
            Double.TryParse(Console.ReadLine(), out nota2);
            double.TryParse(Console.ReadLine(), out nota3);

            if (nota1 > nota2 && nota1 > nota3)
            { 
                media = (nota1 * 4.0 + nota2 * 3.0 + nota3 * 3.0) / 10;
            }
            else if (nota2 > nota3)
            {
                media = (nota1 * 3.0 + nota2 * 4.0 + nota3 * 3.0) / 10;
            }
            else 
            {
                media = (nota1 * 3.0 + nota2 * 3.0 + nota3 * 4.0) / 10;
            }

            if (media >= 5)
            {
                Console.WriteLine($"O aluno com código n.{codigo} obteve as seguintes notas:");
                Console.WriteLine($"{Math.Round(nota1,2)}; {Math.Round(nota2,2)} e {Math.Round(nota3,2)}.");
                Console.WriteLine($"Obteve média = {Math.Round(media,2)}. Sendo APROVADO!");
            }
            else
            {
                Console.WriteLine($"O aluno com código n.{codigo} obteve as seguintes notas:");
                Console.WriteLine($"{Math.Round(nota1,2)}; {Math.Round(nota2,2)} e {Math.Round(nota3,2)}.");
                Console.WriteLine($"e obteve média = { Math.Round(media, 2)}. Sendo REPROVADO!");
            }

        }
    }
}
