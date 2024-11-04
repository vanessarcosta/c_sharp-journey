namespace Exc2b3Peso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso;
            char genero;

            Console.WriteLine("Insira a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o sexo: ");
            genero = Console.ReadKey().KeyChar;


            if(genero == 'M'|| genero == 'm')
            {
                peso = 72.7 * altura -58;
                Console.WriteLine($"\nPeso ideal: {Math.Round(peso,2)}");
            }           
            else if( genero == 'F' || genero == 'f')
            {
                peso = 62.1 * altura - 44.7;
                Console.WriteLine($"\nPeso ideal {Math.Round(peso, 2)}");
            }
        }
    }
}
