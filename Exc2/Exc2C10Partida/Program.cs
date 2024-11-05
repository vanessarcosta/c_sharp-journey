namespace Exc2C10Partida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golsAfavor, golsContra;

            Console.Write("Digite os gols marcados pela equipe: ");
            golsAfavor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dgite os gols sofridos pela equipe: ");
            golsContra = Convert.ToInt32(Console.ReadLine());


            if (golsAfavor == golsContra)
            {
                Console.WriteLine("A equipe empatou a partida!");
            }
            else if (golsAfavor > golsContra)
            {
                Console.WriteLine("A equipe ganhou a partida! ");
            }
            else
            {
                Console.WriteLine("A equipe perdeu a partida.");
            }
        }
    }
}
