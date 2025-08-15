namespace Land
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width, length = 0.0, valueSquareMeter, area, price;

            Console.Write("Digite a largura do terreno: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do terreno: ");
            valueSquareMeter = double.Parse(Console.ReadLine());

            area = width * length;
            price = valueSquareMeter * area;

            Console.WriteLine($"Area do terreno = {area:F2}");
            Console.WriteLine($"Preco do terreno = {price:F2}");
        }
    }
}
