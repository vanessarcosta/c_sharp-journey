using System.Globalization;

namespace ExemploMembrosEstaticos
{
    internal class Program
    {
        // static double Pi = 3.14; tem de ser statico para ser usado em operações staticas versao 1
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora(); versao 2, retira na 3 (com os metodos estaticos não precisa instanciar os objetos
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio); // as chamadas das operações serão feitas diretamemnte pelo nome da Classe
            // e não mais do objeto instanciado da Classe, ver exemplo abaico
            //double circ = calc.Circunferencia(raio);

            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        /* versao primeira 
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }*/
    }
}
