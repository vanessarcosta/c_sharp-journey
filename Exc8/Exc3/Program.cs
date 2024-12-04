namespace Exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, X;

            l = TamanhoDoVetor();

            string[] nomes = new string[l];

            PreencheTabela(nomes);
            
            X = TamanhoDoVetorPrint();
            MostraTabela(nomes,X);

        }

        /// <summary>
        /// Imprimi lista de nomes selecionada
        /// </summary>
        /// <param name="nomes">Lista de nomes</param>
        /// <param name="X">Números de nomes selecionado</param>
        static void MostraTabela(string[] nomes, int X)
        {
            for (int i = 0; i < X; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        /// <summary>
        /// Tamanho do vetor para print
        /// </summary>
        /// <returns>inteiro tamanho da lista</returns>
        static int TamanhoDoVetorPrint()
        {
            int numero;

            do
            {
                Console.Write("Quantos nomes deseja imprimir? ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
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
        /// Pede o tamanho do vetor
        /// </summary>
        /// <returns>numero inteiro</returns>
        static int TamanhoDoVetor()
        {
            int numero;

            do
            {
                Console.Write("Quantos nomes deseja digitar? ");
            }

            while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

    }
}
