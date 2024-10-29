namespace Demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo com dados do tipo char (caracter)

            char input;

            Console.Write("Insira um caracter");
            input = Console.ReadKey().KeyChar;

            Console.Clear();

            Console.WriteLine($"O caracter inserido foi o {input}");
        }
    }
}
