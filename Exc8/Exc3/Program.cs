namespace Exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l;

            l = TamanhoDoVetor();

            string[] nomes = new string[l];

            PreencheTabela(nomes);

        }

        static void PreencheTabela(string[] nomes)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }
        }
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
