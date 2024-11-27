namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matriz com quatro linhas e duas colunas
            string[,] tabela = new string[4, 2];

            //matriz de 3 dimensões
            int[,,] tabela3D = new int[4, 2, 3];

            //Inicializar um array de 2 dimensões
            int[,] tabela2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //Inicializar um array de 3 dimensões
            int[,,] tabela3D_2 = new int[,,] { { { 1, 2, 4 }, { 3, 4, 5 }, { 5, 6, 7 } } };

            //Inserir valores
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Insira o nome: ");
                    tabela[i, j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"tabela[{i},{j}] = {tabela[i,j]}: ");
                }
            }

            Console.WriteLine();

            //mostrar todos os valores da matriz usando o ciclo foreach
            foreach (string nome in tabela)
            {
                Console.WriteLine(nome);
            
            }

            Console.WriteLine("Nomes da primeira coluna");

            //Mostrar apenas os nomes da primeira coluna da tabela
            for (int i = 0; i < 4; i++)
            {
                    Console.WriteLine($"tabela[{i},{0}] = {tabela[i, 0]}: ");
            }

            Console.WriteLine("Nomes da segunda linha");

            //Mostrar apenas os nomes da segunda linha da tabela
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine($"tabela[{1},{j}] = {tabela[1, j]}: ");
            }

            //Numeros de elementos da matriz
            Console.WriteLine(tabela.Length);
            Console.WriteLine(tabela.Rank);
        }
    }
}
