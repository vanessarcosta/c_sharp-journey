namespace Exc6Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a área  triângulo

            double b, h;

            Console.Write("Informe a base do triângulo: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nA área do triângulo é = {Math.Round(b * h / 2, 2)} ");
           
        }
    }
}
