namespace UpdateEmployeesSalary
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }

        public Employee(int id, string name, string salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Id: " + Id + ", " + Name + ", " + Salary + " €.";
        }
    }
}
