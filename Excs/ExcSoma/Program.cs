namespace ExcSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para somar três numeros inseridos pelo usuário

            int numero1, numero2, numero3, resultado;

            Console.Write("Insira o primeiro número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 + numero2 + numero3;

            Console.Clear();

            Console.WriteLine($"{numero1} + {numero2} + {numero3} = {resultado}");



        }
    }
}
