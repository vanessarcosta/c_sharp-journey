namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar e inicializar uma variável
            double saldo = 550.55, valorADepositar;
            string nome = "João";

            Console.WriteLine($"Como se chama ?");
            nome = Console.ReadLine();


            Console.WriteLine($"Quanto quer depositar {nome}.");
            valorADepositar = Convert.ToDouble(Console.ReadLine());

            //saldo = saldo + valorADepositar;
            saldo += valorADepositar;

            Console.Clear();

            Console.WriteLine($"O seu saldo foi atualizado. Agora tem {saldo}");
        }
    }
}
