using SalaryEmployee.Entities;
using System;

namespace SalaryEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();
            int numberEmployees = 0;
            string outsourced;
            double additionalCharge = 0.0;

            Console.Write("Enter the number of employees: ");
            numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                outsourced = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours =int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == "y" || outsourced == "Y")
                {
                    Console.Write("Additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine());
                    Employee newEmployee1 = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    listEmployees.Add(newEmployee1);
                }
                else
                {
                    Employee newEmployee = new Employee(name, hours, valuePerHour);
                    listEmployees.Add(newEmployee);
                }
            }

            Console.WriteLine("PAYMENSTS: ");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
