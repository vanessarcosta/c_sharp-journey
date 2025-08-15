using System.Runtime.ConstrainedExecution;

namespace Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            double valuePerHour, hoursWorked, payment;

            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Horas trabalhadas: ");
            hoursWorked = double.Parse(Console.ReadLine());

            payment = valuePerHour * hoursWorked;
            Console.WriteLine($"O pagamento para {name} deve ser {payment:F2}");

        }
    }
}
