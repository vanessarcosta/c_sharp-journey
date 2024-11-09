namespace Exemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que mostre todos os números impares
            //de um determinado intervalo dado pelo utilizador

            int limiteInferior, limiteSuperior, aux;

            do
            {
                Console.WriteLine("Insira o intervalo inferior");
            }
            while (!int.TryParse(Console.ReadLine(), out limiteInferior));

            do
            {
                Console.WriteLine("Insira o intervalo superior");
            }
            while (!int.TryParse(Console.ReadLine(), out limiteSuperior));

            //Troca os valores dos intervalos se necessários
            if (limiteInferior > limiteSuperior)
            {
                Console.WriteLine("os intervalos vieram trocados, vamos arranjar isso para você.");
                aux = limiteInferior;
                limiteInferior = limiteSuperior;
                limiteSuperior = aux;
            }

            while (limiteInferior <= limiteSuperior)
            {
                if (limiteInferior % 2 == 1)
                {
                    Console.WriteLine(limiteInferior);
                }
                limiteInferior++;                
            }
        }
    }
}
