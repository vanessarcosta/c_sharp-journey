﻿namespace Exc4For_4Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, aux = 0;

            Console.WriteLine("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out numero2);

            if (numero1 > numero2)
            {
                aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            Console.WriteLine();

            for (; numero1 < numero2 - 1; numero1++)
            {
                if (numero1 % 5 != 0.0)
                {
                    Console.WriteLine(numero1);
                }
            }         
        }
    }
}
