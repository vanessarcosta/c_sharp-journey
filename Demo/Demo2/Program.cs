namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que peça ao utiliza dois números e calcula sua soma

            /*
             comentário que ocupam 
            várias linhas
            */

            //Definir primeiro as variáveis
            int numero1, numero2, resultado;

            //Entrada de dados
            Console.Write("Insira o primeiro número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            //Processamento
            resultado = numero1 + numero2;

            Console.Clear();

            //Saida de dados
            //12+10=22
            Console.WriteLine($"{numero1} + {numero2} = {resultado}");
            


        }
    }
}
