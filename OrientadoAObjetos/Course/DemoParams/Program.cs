namespace DemoParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //chamada com sobrecarga
            ////int s1 = Calculator.Sum(2, 3);
            ////int s2 = Calculator.Sum(2, 4, 3);

            //chamada com vetor
            ////int s1 = Calculator.Sum(new int[] { 2, 3 });
            ////int s2 = Calculator.Sum(new int[] { 2, 4, 3});

            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);

           //int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });
           // Console.WriteLine(result);
        }
    }
}
