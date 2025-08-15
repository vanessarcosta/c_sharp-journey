namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahr;
            char temperature;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            temperature = char.Parse(Console.ReadLine());

            if (temperature == 'C')
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine());
                fahr = (celsius * 9) / 5 + 32;
                Console.WriteLine($"Temperatura equivalente em Fahrenheit: {fahr:F2}");
            }
            else
            {
                Console.Write("Digite a temperatura em Fahrenheit:");
                fahr = double.Parse(Console.ReadLine());
                celsius = (fahr - 32) * 5 / 9;
                Console.WriteLine($"Temperatura equivalente em Celsius: {celsius:F2}");
            }

        }
    }
}
