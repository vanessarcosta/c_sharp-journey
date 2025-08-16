namespace AverageAges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, total = 0, counter = 0;
            double average = 0.0;

            Console.WriteLine("Digite as idades");
            age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {

                while (age > 0)
                {
                    total += age;
                    age = int.Parse(Console.ReadLine());
                    counter++;
                }

                average = (double)total / counter;
                Console.WriteLine($"MEDIA = {average:F2}");
            }

        }
    }
}
