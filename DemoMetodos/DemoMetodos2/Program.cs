namespace DemoMetodos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passagem por parâmettos
            //Passagem por valor

            //Passagem por referência

            int n1, n2 = 0, soma;

            n1 = PedirNumero();
            PedirNumeroPorReferencia( ref n2);
        
            soma = Soma(n1, n2);

            Console.WriteLine($"A soma de {n1} com {n2} é de {soma}");

            SomaPorReferencia(n1, n2, ref soma);

            Console.WriteLine($"{n1} + {n2} = {soma}");

        }

        static int Soma(int operando1, int operando2)
        {
            return operando1 + operando2;
        }

        static void SomaPorReferencia(int operando1, int operando2, ref int soma)
        {
            soma = operando1 + operando2;
        }

        static int PedirNumero()
        {
            int numero;

            do
            {
                Console.Write("Insira número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

        static void PedirNumeroPorReferencia(ref int numero)
        {
            do
            {
                Console.Write("Insira número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));
        }
    }
}
