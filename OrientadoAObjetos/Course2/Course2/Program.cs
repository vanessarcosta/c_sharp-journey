using Course2.Services;

namespace Course2
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);

        delegate void BinaryNumericOperation1(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;  //delegate op é uma refencia para funçao Sum
            //Sintaxe alternativa+++
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);+++
            BinaryNumericOperation op1 = CalculationService.Max;

            //BinaryNumericOperation op2 = CalculationService.Square;    // a assinatura da função (1) não casa com a função do delegate (2)
            //no overload for 'Square' matches delegate 'BinaryNumericOperatio'

            //double result = op.Invoke(a, b); ++++++

            double result = op(a, b);
            Console.WriteLine(result);

            result = op1(a, b);
            Console.WriteLine(result);

            result = CalculationService.Square(a);
            Console.WriteLine(result);

            //sem delegate
            ////double result = CalculationService.Sum(a, b);
            ////Console.WriteLine(result);

            ////result = CalculationService.Max(a, b);
            ////Console.WriteLine(result);

            //// result = CalculationService.Square(a);
            ////Console.WriteLine(result);
            ///

            Console.WriteLine("----------Multicast delegate----------------");
            BinaryNumericOperation1 ope = CalculationService.ShowSum;
            ope += CalculationService.ShowMax; // ope guarda referencia para 2 funções

            ope.Invoke(a, b);   // ou pode ---  ope(a, b);
        }
    }
}
