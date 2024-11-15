namespace Exc4For_12DigitoDeControle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i = 0, soma = 0, j = 1, digitoDeControlo = 0;

            do
            {
                Console.Write("Digite um número: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numero));

            //Transforma numero em string
            string numeroStr = numero.ToString();

            i = numeroStr.Length - 1;

            for (; i >= 0; i--)
            {
                //roda o vetor onde está o numero
                // e coloca cada pedaco na variavel digito
                int digito = int.Parse(numeroStr[i].ToString());

                //multiplicar cada digito por 1,2,3.. e somar o produto
                soma += digito * j;

                //contador para a multiplicação
                j++;

            }

            digitoDeControlo = soma % 7;

            //transformei em string, concatenei e imprimir
            Console.WriteLine(String.Concat(numeroStr, digitoDeControlo.ToString()));
        }
    }
}
