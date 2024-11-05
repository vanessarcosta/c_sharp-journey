using System;

namespace Exc2_5MargemLucro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double preco, margemLucro = 0;

            Console.WriteLine("Categoria        Código      Margem de lucro");
            Console.WriteLine("Lacticínios        1                     80%");
            Console.WriteLine("Carnes             2                     80%");
            Console.WriteLine("Peixes             3                    100%");
            Console.WriteLine("Aves               4                    100%");
            Console.WriteLine("Ovos               5                     90%");
            Console.WriteLine("Doces              6                     90%");

            Console.Write("\nInsira o código: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insira o preço de custo: ");
            preco = Convert.ToDouble(Console.ReadLine());

            switch (codigo)
            {
                case int when codigo <= 2:
                    margemLucro = 0.8;                    
                    break;
                case int when codigo <= 4:
                    margemLucro = 1.0;
                    break;
                case int when codigo <= 6:
                   margemLucro = 0.9;
                    break;
            }
            Console.WriteLine($"Valor final do produto {preco += preco * margemLucro} euros");
        }
    }
}