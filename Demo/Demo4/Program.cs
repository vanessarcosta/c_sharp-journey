namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Pedir dois números com casa decimais e calcular a sua média

            double n1, n2, media;

            Console.Write("Insira o primeiro valor: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine($"A média dos valores introduzidos é de {media}");
        }
    }
}
