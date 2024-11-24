using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exc2VetorComDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, i = 0;
            int[] numeros = new int[999];

            while (valor != 999)
            {                
                do
                {
                    Console.Write($"Insira um número inteiro para o vetor ou 999 para finalizar: ");

                }
                while (!int.TryParse(Console.ReadLine(), out valor));

                    numeros[i] = valor;
                    i++;                   
            }

            Console.WriteLine($"Vetor digitado:");

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{numeros[j]}");
            }

        }
    }
}
