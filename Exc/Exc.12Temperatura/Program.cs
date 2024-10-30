namespace Exc._12Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converter temperatura de Fahrenheit para Celsius

            double C,F;
            
            Console.Write("Digite a temperatura em Fahrenheit: ");
            F = Convert.ToDouble(Console.ReadLine());

            C = (F -32) *  (5.0 / 9.0);

            Console.WriteLine($"\nTemperatura equivalente em Celsius = {Math.Round(C, 2)}");
            
        }
    }
}
