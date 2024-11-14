namespace Exemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //somatório de um intervalo dado
            //limite inferior -> 10
            //limite superior -> 15
            //10+11+12+13+14+15 = 75

            int limiteInferior, limiteSuperior, soma = 0;

            Console.Write("Limite inferior: ");
            limiteInferior = Convert.ToInt32(Console.ReadLine());

            Console.Write("Limite superior: ");
            limiteSuperior = Convert.ToInt32(Console.ReadLine());

          //  for (int i = limiteInferior; i <= limiteSuperior; i++)
         // {
        //     soma += i;                
        //    }

            for (; limiteInferior <= limiteSuperior; limiteInferior++)
            {
                soma += limiteInferior;
            }

            Console.WriteLine(soma);
        }
    }
}
