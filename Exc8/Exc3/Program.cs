namespace Exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoVetor, X;

            Console.Write("Quantos nomes deseja digitar? ");
            tamanhoDoVetor = ValidaTamanhoDoVetor();

            string[] nomes = new string[tamanhoDoVetor];
            PreencheTabela(nomes);

            Console.Write("Quantos nomes deseja imprimir? ");
            X = ValidaTamanhoDoVetor();
            MostraTabela(nomes,X);

        }

        /// <summary>
        /// Imprimi lista de nomes selecionada
        /// </summary>
        /// <param name="nomes">Lista de nomes</param>
        /// <param name="X">Números de nomes a selecionar</param>
        static void MostraTabela(string[] nomes, int X)
        {
            for (int i = 0; i < X; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        /// <summary>
        /// Preenche a lista de nomes
        /// </summary>
        /// <param name="nomes">Lista de nomes</param>
        static void PreencheTabela(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
        }

        /// <summary>
        /// Valida o tamanho do vetor
        /// </summary>
        /// <returns>numero</returns>
        static int ValidaTamanhoDoVetor()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Parâmetro inncorreto, digite novamente: ");
            }

            return numero;
        }

    }
}
