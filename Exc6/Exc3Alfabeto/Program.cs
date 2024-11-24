namespace Exc3Alfabeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar no próprio vetor
            //char[] chars = new char[16] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P'};

            //Tabela ASCII
            char[] chars = new char[16];
            int cont = 65;

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)cont;
                cont++;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
        }
    }
}
