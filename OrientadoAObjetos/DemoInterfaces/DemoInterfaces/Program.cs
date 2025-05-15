namespace DemoInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPorPagar> listaDePagamentos = new List<IPorPagar>
            {
                new Fatura("100", "Renda do escritório", 1, 1500.00),
                new Fatura("200", "Garrafas de água", 25, 0.80),

                new EmpregadoAssalariado("E100", "Joana", "Matos", 1000.00),
                new EmpregadoAssalariado("E200","Carlos", "Mota", 875.50)
            };

            foreach(var aPagar in listaDePagamentos)
            {
                Console.WriteLine(aPagar);
            }
        }
    }
}
