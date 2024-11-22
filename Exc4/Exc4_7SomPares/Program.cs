namespace Exc4_7SomPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, aux = 0, soma = 0;

            do
            {
                Console.Write("Digite o primeiro número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero1));

            do
            {
                Console.Write("Digite o segundo número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero2));

            if (numero1 > numero2)
            {
                aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            do
            {
                if (numero1 % 2.0 == 0)
                {
                    soma += numero1;
                }                                
                numero1++;
            }
            while (numero1 <= numero2);

            Console.WriteLine($"Somatório dos pares do intervalo = {soma}");

          
        }
    }
}
