using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exc5converterKmMIilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double km, milhas;obrigada

            do
            {
                Console.Write("Deseja converter: Km pra milhas (digite 1) ou milhas para km (digite 2)?");
            }
            while (!int.TryParse(Console.ReadLine(), out escolha));

            if (escolha == 1)
            {
                do
                {
                    Console.Write("Informe o valor em quilômetros: ");
                  
                }
                while (!double.TryParse(Console.ReadLine(), out km)); 

                    milhas = km * 0.621371;
                Console.WriteLine($"{km} Km equivale {Math.Round(milhas, 2)} milhas.");
            }
            else if (escolha == 2) 
            {
                do
                {
                    Console.Write("Informe o valor em milhas: ");
                }
                while (!double.TryParse(Console.ReadLine(), out milhas));
                km = milhas * 1.60934;
                Console.WriteLine($"{milhas} milhas equivale {Math.Round(km,2)} Km.");
            }
            else
            {
                Console.Write("Valor inválido!");
            }
           
        }
    }
}
