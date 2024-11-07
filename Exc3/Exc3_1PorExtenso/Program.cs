using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exc3_1PorExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Digite um número!");
            numero = Convert.ToInt32(Console.ReadLine());

            string numeroExtenso = numero switch
            {
                0 => "zero",
                1 => "um",
                2 => "dois",
                3 => "três",
                4 => "quatro",
                5 => "cinco",
                6 => "seis",
                7 => "sete",
                8 => "oito",
                9 => "nove",
                10 => "dez",                
            };
            Console.WriteLine($"Numero por extenso: {numeroExtenso}");

        }
    }
}
