namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir e mostrar cinco nomes e apelidos

            string nome, apelido;
            int i = 1;

            do
            {
                Console.Write($"Insira o nome {i}: ");
                nome = Console.ReadLine();

                Console.Write($"Insira o apelido {i}: ");
                apelido = Console.ReadLine();

                Console.WriteLine($"Olá, {nome} {apelido}");     
                
                i++;

            }
            while (i <= 5);

        }
    }
}
