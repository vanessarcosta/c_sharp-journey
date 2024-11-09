namespace Exc9_MediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double nota1, nota2, nota3, media;   

            do
            {
                Console.Write("Digite o código do aluno: ");
            }

            while (!int.TryParse(Console.ReadLine(), out codigo));

            do
            {
                Console.WriteLine("Digite a primeira nota: ");
            }
            while (!double.TryParse(Console.ReadLine(), out nota1));

            do
            {
                Console.WriteLine("Digite a segunda nota: ");
            }
            while (!Double.TryParse(Console.ReadLine(), out nota2));

            do
            {
                Console.WriteLine("Digite a terceira nota: ");
            }
            while (!double.TryParse(Console.ReadLine(), out nota3));
            
            
            if (nota1 > nota2 && nota1 > nota3)
            { 
                media = Math.Round((nota1 * 4.0 + nota2 * 3.0 + nota3 * 3.0) / 10);
            }
            else if (nota2 > nota3)
            {
                media =  Math.Round((nota1 * 3.0 + nota2 * 4.0 + nota3 * 3.0) / 10);
            }
            else 
            {
                media = Math.Round((nota1 * 3.0 + nota2 * 3.0 + nota3 * 4.0) / 10);
            }

            Console.WriteLine($"O aluno com código n.{codigo} obteve as seguintes notas:");
            Console.WriteLine($"{nota1}; {nota2} e {nota3}.");

            if (media >= 5.0)
            {
                Console.WriteLine($"Obteve média = {media}. Sendo APROVADO!");
            }
            else
            {
                Console.WriteLine($"e obteve média = {media}. Sendo REPROVADO!");
            }

        }
    }
}
