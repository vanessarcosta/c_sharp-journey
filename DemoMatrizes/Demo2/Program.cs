namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] golos = new int[6, 2];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(j == 0)
                    {
                        do
                        {
                            Console.Write($"Golos marcados na jornada {i + 1}: ");
                           
                        } while (!int.TryParse(Console.ReadLine(), out golos[i, j]));
                    }
                    else
                    {
                        do
                        {
                            Console.Write($"Golos marcados na jornada {i + 1}: ");

                        } while (!int.TryParse(Console.ReadLine(), out golos[i, j]));
                    }
                }
            }

            Console.WriteLine("Pressione qualquer tecla para avançar...");
            Console.ReadKey();

            Console.Clear();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Jornada {i + 1} - Marcados: {golos[i, 0]} Sofridos: {golos[i, 1]}");
            }

        }
    }
}
