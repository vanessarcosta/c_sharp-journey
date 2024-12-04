namespace Exc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiraString, segundaString;

            Console.Write($"Insira o primeiro conjunto de caracteres: ");
            primeiraString = Console.ReadLine();

            Console.Write($"Insira o segundo conjunto de caracteres: ");
            segundaString = Console.ReadLine();

            TrocarStrings(ref primeiraString, ref segundaString);

            Console.WriteLine("\nTROCA O CONJUNTO DE CARACTERES");
            Console.WriteLine($"Primeiro conjunto de caracteres: {primeiraString}.");
            Console.WriteLine($"Segundo conjunto de caracteres: {segundaString}");
        }
        /// <summary>
        /// Troca de variavel
        /// </summary>
        /// <param name="primeiroParametro">Primeira variavel</param>
        /// <param name="segundoParametro">Segunda variavel</param>
        static void TrocarStrings(ref string primeiroParametro, ref string segundoParametro)
        {
            string aux = primeiroParametro;
            primeiroParametro = segundoParametro;
            segundoParametro = aux;
        }
    }
}
