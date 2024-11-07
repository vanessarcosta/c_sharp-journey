namespace Exc4_2ListaNumSemDivisor5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine(numero);
            do
            {                
                numero++;

                if (numero % 5 !=0.0)
                {                  
                    Console.WriteLine(numero);
                }                
            }
            while (numero < 20);

        }
    }
}
