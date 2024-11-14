namespace EXC5_4CapitalAcumulado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital = 1500.0, taxaAnual = 0.02, capitalAcumulado = 0;

            for (int anos = 1; anos <= 3; anos++)
            {
                capitalAcumulado = capital * Math.Pow((1 + taxaAnual), anos);
                taxaAnual += 0.005;
                Console.WriteLine($"O capital total é de {Math.Round(capitalAcumulado, 2)} euros em {anos} ano(s).");
            }            
        }
    }
}
