namespace Consumption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance, fuel, averageConsumption;

            Console.Write("Distancia percorrida: ");
            distance = double.Parse(Console.ReadLine());
            Console.Write("Combustivel gasto: ");
            fuel = double.Parse(Console.ReadLine());
            
            averageConsumption = distance / fuel;
            Console.WriteLine($"Consumo medio = {averageConsumption:F3}");
            
        }
    }
}
