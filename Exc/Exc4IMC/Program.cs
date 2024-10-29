namespace Exc4IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o IMC

            double peso, altura;

            Console.Write("Digite o seu peso em kg: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o sua altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nO seu IMC: {Math.Round(peso / (altura * altura),2)}");

        }
    }
}
