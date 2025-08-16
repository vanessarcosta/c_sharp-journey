namespace Fuel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fuel, alcohol, gasoline, diesel;

            alcohol = 0;
            gasoline = 0;
            diesel = 0;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar:");
            fuel = int.Parse(Console.ReadLine());

            while (fuel != 4)
            {
                switch (fuel)
                {
                    case 1:
                        alcohol += 1;
                        break;
                    case 2:
                        gasoline += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                }

                Console.WriteLine("Informe um codigo (1, 2, 3) ou 4 para parar:");
                fuel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcohol}");
            Console.WriteLine($"Gasolina {gasoline}");
            Console.WriteLine($"Diesel: {diesel}" );

        }
    }
}
