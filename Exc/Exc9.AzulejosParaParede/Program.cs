namespace Exc9.AzulejosParaParede
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a quantidade de azulejos para uma parede

            double hp, ha, lp, la;

            Console.Write("Digite em metros a altura da parede: ");
            hp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite em metros a largura da parede: ");
            lp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite em centímetros a altura do azulejo: ");
            ha = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite em centímetros a largura do azulejo: ");
            la = Convert.ToDouble(Console.ReadLine());

            la = la / 100;
            ha = ha / 100;
            
            Console.WriteLine($"\n Será necessário {Math.Ceiling((hp * lp) /(ha * la))} azulejos ");
            
        }
    }
}
