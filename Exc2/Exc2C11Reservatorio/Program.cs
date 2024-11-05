namespace Exc2C11Reservatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, largura, comprimento, consumoMedio;
            double autonomia;    
            
            Console.Write("Digite a altura do reservatório: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a largura do reservatório: ");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a comprimento do reservatório: ");
            comprimento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o consumo médio diário de água: ");
            consumoMedio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nA capacidade total do reservátorio é de {Math.Pow(comprimento, 3) * 1000.0}.");
            autonomia = Math.Pow(comprimento, 3) * 1000.0 / consumoMedio;
            Console.WriteLine($"\nA autonomia do reservátorio é de {autonomia} dias.");

            if (autonomia >= 7.0)
            {
                Console.WriteLine("Consumo reduzido.");
            }
            else if (autonomia >= 2)
            {
                Console.WriteLine("Consumo moderado.");
            }
            else
            {
                Console.WriteLine("Consumo elevado.");
            }
        }
    }
}
