namespace Exc1Enfermaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] enfermaria = new int[24,4];


            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine($"{i} hora(s). Insira a pulsação:");

                for (int j = 0; j < 4; j++)
                {
                    do
                    {                        
                        Console.Write($"Paciente do leito {j + 1}: ");
                    } while (!int.TryParse(Console.ReadLine(), out enfermaria[i, j]));
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para verificar resultados...");
            Console.ReadKey();
            Console.Clear();

            double totalPulsacao = 0;
            double[] mediaPulsacoes = new double[4];

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 24; i++)
                {
                    totalPulsacao += enfermaria[i, j];
                }

                Console.WriteLine($"A média de pulsação do paciente do leito {j + 1}:" +
                   $" {totalPulsacao / 3:N2}\n");
                mediaPulsacoes[j] = totalPulsacao / 24;
                totalPulsacao = 0;
            }

            int posicaoLeito = 0;
            double maiorValor = 0;

            for (int i = 0; i < mediaPulsacoes.Length; i++)
            {
                if (mediaPulsacoes[i] > maiorValor)
                {
                    maiorValor = mediaPulsacoes[i];
                    posicaoLeito = i;
                }
            }
            Console.WriteLine($"O paciente do leito {posicaoLeito + 1} apresentou o maior " +
                $"valor médio entre os leitos com {maiorValor:N2} pulsações. \n");

            int maiorPulsacao = 0, leito =0, hora = 0;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(enfermaria[i,j] > maiorPulsacao)
                    {
                        maiorPulsacao = enfermaria[i,j];
                        leito = j;
                        hora = i;
                    }

                }
            }

            Console.WriteLine($"O paciente do leito {leito+ 1} apresentou às {hora}hora(s) " +
            $"a maior pulsação entre os leitos com {maiorPulsacao} pulsações.\n");

        }
    }
}
