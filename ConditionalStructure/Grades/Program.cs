namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade1, grade2, total;

            Console.Write("Digite a primeira nota: ");
            grade1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            grade2 = double.Parse(Console.ReadLine());

            total = grade1 + grade2;

            Console.WriteLine($"NOTA FINAL = {total:F1}");
            if(total < 60)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}
