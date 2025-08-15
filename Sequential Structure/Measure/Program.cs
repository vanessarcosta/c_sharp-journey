namespace Measure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double measureA, measureB, measureC, areaSquare, areaTriangle, areaTrapezoid;

            Console.Write("Digite a medida A: ");
            measureA = double.Parse(Console.ReadLine());
            Console.Write("Digite a medida B: ");
            measureB = double.Parse(Console.ReadLine());
            Console.Write("Digite a medida C: ");
            measureC = double.Parse(Console.ReadLine());

            areaSquare = Math.Pow(measureA, 2);
            areaTriangle = measureA * measureB / 2;
            areaTrapezoid = (measureA + measureB) * measureC / 2;

            Console.WriteLine($"AREA DO QUADRADO = {areaSquare:F4}");
            Console.WriteLine($"AREA DO TRIANGULO = {areaTriangle:F4}");
            Console.WriteLine($"AREA DO TRAPEZIO = {areaTrapezoid:F4}");

        }
    }
}
