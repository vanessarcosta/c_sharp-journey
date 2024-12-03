
namespace DemoMetodos3
{
    internal class Program
    {
        //Nos arrays, vetores ou matrizes,
        //e strings é sempre por defeito
        //passadas por referência sem ser necessário usar a palava-reservada "ref"
        static void Main(string[] args)
        {
            string[] turma = new string[5];
            int[] notas = new int[5];

            string nomeAProcurar;

            PreencheTabela(turma);
            PreencheTabela(notas);

            MostraTabela(turma);
            MostraTabela(notas);

            Console.WriteLine($"A maior nota foi {Maior(notas)}");

            Console.WriteLine($"{turma[PosicaoDoMaior(notas)]}");

            Console.Clear();

            Console.Write("Que nome quer procurar: ");
            nomeAProcurar = Console.ReadLine();

            if(ProcuraNome(turma, nomeAProcurar))
            {
                Console.WriteLine("O nome foi encontrado.");
            }
            else
            {
                Console.WriteLine("O nome não foi encontrado");
            }
        }

        /// <summary>
        /// Procura se existe um determinado nome numa tabela
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="nome"></param>
        /// <returns>um valor booleano dizendo se encontrou ou não</returns>
        static bool ProcuraNome(string[] tabela, string nome)
        {
            bool encontrou = false;

            for (int i = 0; i < tabela.Length; i++)
            {
                if(nome == tabela[i])
                { 
                    encontrou = true;
                }
            }
            return encontrou;
        }

        /// <summary>
        /// posição do array em que se encontra o maior valor
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns>um número inteiro maior</returns>
        static int PosicaoDoMaior(int[] tabela)
        {
            int maior = 0, posicao = -1;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i] > maior)
                {
                    maior = tabela[i];
                    posicao = i;
                }
            }
            return posicao;
        }

        /// <summary>
        /// procura o maior inteiro numa tabela de inteiros
        /// </summary>
        /// <param name="tabela"></param>
        /// <returns>o inteiro maior</returns>
        static int Maior(int[] tabela)
        {
            int maior = 0;

            for (int i = 0; i < tabela.Length; i++)
            {
                if( tabela[i] > maior)
                {
                    maior = tabela[i]; 
                }
            }

            return maior;
        }

        /// <summary>
        /// Preenche um array vetor de inteiros
        /// </summary>
        /// <param name="tabela"></param>
        static void PreencheTabela(int[] tabela)
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                do
                {
                    Console.Write($"Insira a nota {i + 1} ");
                } while (!int.TryParse(Console.ReadLine(), out tabela[i]));        
            }
        }
        /// <summary>
        /// Preenche um array vetor de strings
        /// </summary>
        /// <param name="tabela"></param>
        static void PreencheTabela(string[] tabela)
        {
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write($"Insira o nome {i + 1}: ");
                tabela[i] = Console.ReadLine();
            }
        }

        static void MostraTabela(string[] tabela)
        {
            foreach (string texto in tabela)
            {
                Console.WriteLine(texto);
            }
        }

        static void MostraTabela(int[] tabela)
        {
            foreach (int numero in tabela)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
