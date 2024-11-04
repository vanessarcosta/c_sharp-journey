using System;
using System.Diagnostics;

namespace Exc2_7Frutaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int codigo, quantidade;
            double valorPagar = 0.0;

            Console.WriteLine("Especificação         Código");
            Console.WriteLine("Morango               100");
            Console.WriteLine("Maça                  101");

            Console.WriteLine("Código:");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());



            switch (codigo)
            {
                case 100:
                    if (quantidade <= 5)
                    {
                        valorPagar = quantidade * 2.5;
                    }
                    else
                    {
                        valorPagar = quantidade * 2.2;
                    }
                break;
                case 101:
                    if (quantidade <= 5)
                    {
                        valorPagar = quantidade * 1.8;
                    }
                    else
                    {
                        valorPagar = quantidade * 1.5;
                    }
                break;
                default:
                    Console.WriteLine("Código inválido!");
                break;                        
            }
            if (quantidade > 8.0 ||  valorPagar > 25.0) 
            {
                valorPagar = valorPagar - (valorPagar * 0.1);
                Console.WriteLine($"Valor a pagar = {valorPagar} euros");
            }
            else
            {
                Console.WriteLine($"Valor a pagar = {valorPagar} euros");
            }
        }
    }
}
