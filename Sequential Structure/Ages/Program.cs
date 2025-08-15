namespace Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;
            int age1, age2;
            double average;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            name1 = Console.ReadLine();
            Console.Write("Idade: ");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            name2 = Console.ReadLine();
            Console.Write("Idade: ");
            age2 = int.Parse(Console.ReadLine());

            average = (double) (age1 + age2) / 2;
            Console.WriteLine($"A idade média de {name1} e {name2} é de {average:F1} anos");

        }
    }
}
