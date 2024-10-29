namespace Exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double euro;

            Console.Write("Digite a quantia em euros: ");
            euro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($" A quantia de {euro} EUR equivale a {euro * 1.08} USD"); 
        }
    }
}
