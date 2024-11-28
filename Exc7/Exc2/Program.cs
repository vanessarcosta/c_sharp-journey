namespace Exc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        Console.Write($"Insira os valores na matriz: ");
                    } while (!int.TryParse(Console.ReadLine(), out numeros[i, j]));
                }
            }

            for (int i = 0; i < 3; i++) // Itera pelas linhas
            {
                for (int j = 0; j < 3; j++) // Itera pelas colunas
                {
                    Console.Write(numeros[i, j] + " ");
                }
                Console.WriteLine(); // Pula para a próxima linha
            }

            int maiorElemento = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (numeros[i, j] > maiorElemento)
                        maiorElemento = numeros[i, j];   
                }
            }

            Console.WriteLine("Pressione qualquer tecla para prosseguir...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"O maior elemento da matriz é {maiorElemento}\n");

            double totalCol = 0;
            
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    totalCol += numeros[j,i];
                    
                }
                Console.WriteLine($"A média dos elementos da coluna {k} é {totalCol / 3:N2}\n");
                k++;
                totalCol = 0;
            }

            int somaLin3 = 0;
            for (int j =0; j < 3; j++)
            {
                somaLin3 += numeros[2,j];
            }

            Console.WriteLine($"A soma dos elementos da linha 3 é {somaLin3}\n");

            int col= 0;
            do
            {
                Console.Write($"Escolha uma coluna: ");
            } while (!int.TryParse(Console.ReadLine(), out col));

            int somaLin = 0;
            col -= 1;
            for (int j = 0; j < 3; j++)
            {
                somaLin += numeros[j,col];
            }
            Console.WriteLine($"A soma dos elementos da coluna {col+1} é {somaLin}\n");

            int somaDiagonal = 0;
            for (int i = 0; i < 3; i++)
            {
                somaDiagonal += numeros[i,i];
            }
            Console.WriteLine($"A soma dos elementos da diagonal principal é {somaDiagonal}\n");
        }
    }
}
