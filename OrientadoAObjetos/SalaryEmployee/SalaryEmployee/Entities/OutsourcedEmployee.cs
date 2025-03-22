namespace SalaryEmployee.Entities
{
    class OutsourcedEmployee: Employee
    {
        public double AdditionalCharge; 
        
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionlCharge) 
        :base(name, hours, valuePerHour)
        {
            AdditionalCharge = valuePerHour;
        }

        public override double Payment()
        {
            return (AdditionalCharge * 1.1) + base.Payment();
        }
    }
}
