namespace UpdateEmployeesSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ids = new List<int>();
            List<string> names = new List<string>();
            List<double> salaries = new List<double>();

            Console.Write(" How many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                ids.Add(id);
                names.Add(name);
                salaries.Add(salary);

            }
            Console.WriteLine();
        }
    }
}
