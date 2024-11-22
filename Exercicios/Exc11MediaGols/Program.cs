namespace Exc11MediaGols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            double golsSofridos = 0, totalDeGols = 0, aux = 0;
            int partida = 1;

            while (golsSofridos != 3)
            { 
                do
                {
                    Console.WriteLine($"Quantos golos o Sporting sofreu na partida: ");

                } while (!double.TryParse(Console.ReadLine(), out golsSofridos));

                partida++;
                totalDeGols += golsSofridos;

            }

            media = totalDeGols / partida;

            Console.WriteLine($"A média de golos sofridos pelo Sporting é: {media}");
        }
    }
}
