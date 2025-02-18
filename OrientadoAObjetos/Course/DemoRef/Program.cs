namespace DemoRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =10;

            ////chamada sem ref
            //Calculator.Triple(a);
            
            //chamada com ref
            Calculator.Triple(ref a);

            Console.WriteLine(a);

            int b = 10;
            int quadruple;
            Calculator.Quadruple(b, out quadruple);
            Console.WriteLine(quadruple);
        }
    }
}
