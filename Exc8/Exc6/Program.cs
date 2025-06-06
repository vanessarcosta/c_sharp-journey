﻿namespace Exc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas =0;

            segundos = PedeNumero();

            (minutos,segundos) = ConverteMinutosEHoras(ref segundos);

            if (minutos > 60) 
            { 
                (horas,minutos) = ConverteMinutosEHoras(ref  minutos);
            }
            Console.WriteLine($"O valor em segundos equivale a {horas} horas, {minutos} minutos e {segundos} secundos.");

        }

        /// <summary>
        /// Converte segundos em minutos e horas
        /// </summary>
        /// <param name="numero">Números em segundos</param>
        /// <returns>numero</returns>
        static (int, int) ConverteMinutosEHoras( ref int numero)
        {
            int resto = 0;
            if (numero % 60 != 0)
            {
                resto = numero % 60;
            }
            numero = numero / 60;
            return (numero, resto);

        }

        /// <summary>
        /// Valida numero inserido pelo usúario
        /// </summary>
        /// <returns>numero</returns>
        static int PedeNumero()
        {
            int numero;

            do
            {
                Console.Write("Digite o valor em segundo para converter: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }
    }
}
