using System.ComponentModel.Design;

namespace Exc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3,3];
            int linha = 0, coluna = 0, soma =0;

            PreencheMatriz(numeros);

            Console.WriteLine("Para mostrar valores informe as coordenadas: ");
            Console.Write("Digite a linha: ");
            linha = ValidaQuantidade();
            MostraLinhaOuColuna(numeros, linha,0);
            
            Console.Write("\nDigite a coluna: ");
            coluna = ValidaQuantidade();            
            MostraLinhaOuColuna(numeros, 0, coluna);

            soma+= SomaLinhaOuColuna(numeros, linha, 0);
            soma += SomaLinhaOuColuna(numeros, 0, coluna);
           
            Console.WriteLine($"\nA soma dos valores da linha {linha} e coluna {coluna} = {soma} ");

        }
        static int SomaLinhaOuColuna(int[,] elemento, int i, int j)
        {
            int soma = 0;
            if (i != 0)
            {
                for (; j < 3; j++)
                {
                    soma += elemento[i - 1, j];
                }
            }
            else
            {
                for (; i < 3; i++)
                {
                    soma += elemento[i, j - 1];
                }
            }
            return soma;
        }
        static void MostraLinhaOuColuna(int[,] elemento, int i, int j)
        {
            if (i != 0)
            {
                Console.WriteLine($"Linha {i}: ");
                for (; j < 3; j++)
                {
                    Console.Write(elemento[i - 1, j] + " ");
                }
            }
            else
            {
                Console.WriteLine($"Coluna {j}: ");
                for (; i < 3; i++)
                {
                    Console.Write(elemento[i, j - 1] + " ");
                }
            }
        }
        static void PreencheMatriz(int[,] elemento) 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        Console.Write($"Insira os valores na matriz: ");
                    } while (!int.TryParse(Console.ReadLine(), out elemento[i, j]));
                }
            }
        }

        static int ValidaQuantidade()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Parâmetro incorreto, digite novamente: ");
            }
            return numero;
        }
    }
}
