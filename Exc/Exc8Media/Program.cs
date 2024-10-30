namespace Exc8Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a media de quatro notas

            double nota1, nota2, nota3, nota4;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"\nMédia final = {Math.Round((nota1 + nota2 +nota3 + nota4) / 4, 2)} ");
            
        }
    }
}
