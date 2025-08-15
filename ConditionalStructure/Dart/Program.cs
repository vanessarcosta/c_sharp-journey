namespace Dart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance1, distance2, distance3, bigger;

            Console.WriteLine("Digite as tres distancias:");
            distance1 = double.Parse(Console.ReadLine());
            distance2 = double.Parse(Console.ReadLine());
            distance3 = double.Parse(Console.ReadLine());

            if (distance1 > distance2 && distance1 > distance3)
            {
                bigger = distance1;
            }
            else if (distance2 > distance3)
            {
                bigger = distance2;
            }
            else
            {
                bigger = distance3;
            }

            Console.WriteLine($"MAIOR DISTANCIA = {bigger:F2}");
        }
    }
}
