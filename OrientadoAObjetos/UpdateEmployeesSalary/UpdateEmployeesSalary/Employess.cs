namespace UpdateEmployeesSalary
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Id: " + Id + ", " + Name + ", " + Salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += percentage * Salary / 100.00;
        }
    }
}
