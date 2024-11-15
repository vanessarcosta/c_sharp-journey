namespace Exc4For_10MesmaAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alturaJoao = 1.50, alturaZe = 1.10;
            int i = 0;

            for (; alturaZe < alturaJoao; i++)
            {
                alturaJoao += 0.02;
                alturaZe += 0.03;
            }
            
            Console.WriteLine($"É necessários {i} anos para que Zé seja maior que João.");
        }
    }
}
