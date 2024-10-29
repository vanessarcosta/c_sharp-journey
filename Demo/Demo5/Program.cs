namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedidr dois números com casas decimais e calcular a sua média
            //Usando só duas variáveis e arredondando ---Math. Round () --- a média final
            double n1, n2;

            Console.Write("Insira o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A média dos valores introduzidos é de {Math.Round((n1 +n2)/2,2)}");
        }
    }
}
