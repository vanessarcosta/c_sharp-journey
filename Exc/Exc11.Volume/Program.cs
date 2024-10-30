namespace Exc11.Volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o volume de uma lata de óleo

            double v, r, a;             
 ;
            Console.Write("Informe a altura de uma lata de óleo: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o raio de uma lata de óleo: ");
            r = Convert.ToDouble(Console.ReadLine());

            v = 3.14159 * r * r * a;

            Console.WriteLine($"\nValor do volume de uma lata de óleo {Math.Round(v,2)} ");
        }
    }
}
