namespace Exc1Enfermaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] golos = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Insira a pulsação do paciente da {i}: hora(s) ");
                    do
                        {
                            Console.Write($"Paciente do leito {j + 1}: ");

                        } while (!int.TryParse(Console.ReadLine(), out golos[i, j]));
             
                }
            }
        }
    }
}
