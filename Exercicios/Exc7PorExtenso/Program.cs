using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exc7PorExtenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idioma, numero;

            Console.Write("Qual idioma deseja imprimir? Ingles (digite 1) ou português (digite 2): ");
            idioma = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um número entre 1 e 5: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (idioma)
            {
                case 1:

                    switch (numero)
                    {
                        case 1:
                            Console.Write("One.");
                            break;
                        case 2:
                            Console.Write("Two.");
                            break;
                        case 3:
                            Console.Write("Three.");
                            break;
                        case 4:
                            Console.Write("Four.");
                            break;
                        case 5:
                            Console.Write("Five.");
                            break;                    }
                    break;
                case 2:

                    switch (numero)
                    {
                        case 1:
                            Console.Write("Um.");
                            break;
                        case 2:
                            Console.Write("Dois.");
                            break;
                        case 3:
                            Console.Write("Três.");
                            break;
                        case 4:
                            Console.Write("Quatro.");
                            break;
                        case 5:
                            Console.Write("Cinco.");
                        break;
                    }
                    break;
            }

        }
    }
    
}
