namespace Exc2C4Poligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lados;
            double medida, apotema;

            Console.WriteLine("Digite o número de lados: ");
            lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a medida em cm");
            medida = Convert.ToInt32(Console.ReadLine());

            if (lados == 3)
            {
                medida = ((Math.Sqrt(3) / 4) * Math.Pow(medida, 2));
                Console.WriteLine($"Triângulo com área = {Math.Round(medida, 2)}");
            }
            else if (lados == 4)
            {
                medida = Math.Pow(medida, 2);
                Console.WriteLine($"Quadrado com área = {Math.Round(medida, 2)}");
            }
            else if(lados == 5)
            {
                    apotema = medida / (2 * Math.Tan(Math.PI / 5));                    
                    medida =  (medida * 5) * apotema /2;
                Console.WriteLine($"Triângulo com área = {Math.Round(medida,2)}");
            }
            else if (lados < 3)
            {            
                Console.WriteLine("Não é um polígono.");
            }
            else if (lados > 5)
            {
                Console.WriteLine($"Polígono não identificado.");
            }
        }
    }
}
