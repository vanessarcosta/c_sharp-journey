namespace Exc1Enfermaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] enfermaria = new int[3, 2];
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    
                    do
                        {
                            Console.WriteLine($"Insira a pulsação do paciente da {i}: hora(s) ");
                            Console.Write($"Paciente do leito {j + 1}: \n");

                        } while (!int.TryParse(Console.ReadLine(), out enfermaria[i, j]));
             
                }
            }

            double totalPulsacao = 0;
            double[] mediaPulsacoes = new double[2];
            
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    totalPulsacao += enfermaria[i, j];
                }

                Console.WriteLine($"A média de pulsação do pa ciente do leito {j+1} ="+
                   $"\n {totalPulsacao/3:N2}"); 
                mediaPulsacoes[j] = totalPulsacao/3;
                totalPulsacao = 0;
            }
        }
    }
}
