namespace Increase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, newSalary, increase, percentage;

            Console.Write("Digite o salario da pessoa: ");
            salary = double.Parse(Console.ReadLine());

            if (salary  <= 1000.00)
            {
                percentage = 0.20;
            }
            else if (salary <= 3000.00)
            {
                percentage = 0.15;
            }
            else if(salary <= 8000.00)
            {
                percentage = 0.10;
            }
            else
            {
                percentage = 0.5;
            }

            newSalary = salary * percentage + salary;
            increase = newSalary - salary;

            Console.WriteLine($"Novo salario = {newSalary:F2}");
            Console.WriteLine($"Aumento = {increase:F2}");
            Console.WriteLine($"Porcentagem = {percentage * 100}%");

        }
    }
}
