namespace Exc4_7SomPares
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

            do
            {                
                if (numero1 % 2.0 == 0)
                {                    
                    aux += numero1;
                }
                numero1++;
            }
            while (numero1 < numero2 - 1);
            Console.WriteLine($"Somatório do intervalo = {aux}");
        }
    }
}
