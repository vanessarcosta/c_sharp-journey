using System.Reflection.Metadata;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRectangle, height, area, perimeter, diagonal;
            Console.Write("Base do retangulo: ");
            baseRectangle = double.Parse(Console.ReadLine());
            Console.Write("Altura do retangulo: ");
            height = double.Parse(Console.ReadLine());

            area = baseRectangle * height;
            perimeter = 2 * (baseRectangle + height);
            diagonal = Math.Sqrt(Math.Pow(baseRectangle, 2.0) + Math.Pow(height, 2.0));

            Console.WriteLine($"AREA = {area:F4}");
            Console.WriteLine($"PERIMETRO = {perimeter:F4}");
            Console.WriteLine($"DIAGONAL = {diagonal:F4}");
        }
    }
}
