namespace GradeValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade1, grade2, average;

            Console.Write("Digite a primeira nota: ");
            grade1 = double.Parse(Console.ReadLine());

            while (grade1 < 0 || grade1 > 10)
            {
                Console.Write("Valor invalido! Tente novamente");
                grade1 = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite a segunda nota: ");
            grade2 = double.Parse(Console.ReadLine());

            while (grade2 < 0 || grade2 > 10)
            {
                Console.Write("Valor invalido! Tente novamente");
                grade2 = double.Parse(Console.ReadLine());
            }

            average = (grade1 + grade2) / 2;

            Console.WriteLine($"MEDIA = {average:F2}");
        }
    }
}
