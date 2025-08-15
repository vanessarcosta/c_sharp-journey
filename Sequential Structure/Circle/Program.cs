namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area; 

            Console.Write("Digite o valor do raio do circulo: ");
            radius = double.Parse(Console.ReadLine());

            area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"AREA = {area:F3}");

        }
    }
}
