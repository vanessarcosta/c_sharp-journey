namespace Exc4_10MesmaAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alturaJoao = 1.50, alturaZe = 1.10;
            int contador = 0;

            while (alturaZe < alturaJoao)
            {
                contador ++;
                alturaJoao += 0.02;
                alturaZe += 0.03 ;
            }
            Console.WriteLine($"É necessários {contador} anos para que Zé seja maior que João.");
        }
    }
}
