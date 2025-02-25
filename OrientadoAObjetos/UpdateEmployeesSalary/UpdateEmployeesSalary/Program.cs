using System.Collections.Generic;
using UpdateEmployeesSalary;
namespace UpdateEmployeesSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int id;
            double percentage;
            

            Console.Write(" How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employees.Add(new Employee(id, name, salary));
            }
            Console.WriteLine();

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            Employee index = employees.Find(x => x.Id == id);
            if (index != null)
            {
                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine());
                index.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employess: ");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
