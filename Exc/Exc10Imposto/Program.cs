namespace Exc10Imposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular imposto de um terreno sobre area total/construida

            double areaTotal, areaConstrucao, imposto;

            Console.Write("Digite em metros a área total do terreno: ");
            areaTotal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite em metros a área construída do terreno: ");
            areaConstrucao = Convert.ToDouble(Console.ReadLine());

            areaTotal = areaTotal - areaConstrucao;
            imposto = areaTotal * 5.80 + areaConstrucao * 50.00; 
                        
            Console.WriteLine($"\n Valor total do imposto {Math.Round(imposto,2)} Euros ");

        }
    }
}
