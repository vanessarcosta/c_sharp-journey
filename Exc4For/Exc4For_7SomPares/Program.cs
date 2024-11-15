namespace Exc4For_7SomPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, aux = 0;

            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out numero2);

            numero1 += 1;
            for (; numero1 < numero2; numero1++)
            {
                if (numero1 % 2.0 == 0)
                {
                    aux += numero1;
                }
            }

            Console.WriteLine($"Somatório do intervalo = {aux}");
        }
    }
}
