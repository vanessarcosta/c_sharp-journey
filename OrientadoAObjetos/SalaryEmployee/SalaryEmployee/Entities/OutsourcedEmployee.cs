﻿namespace SalaryEmployee.Entities
{
    class OutsourcedEmployee: Employee
    {
        public double AdditionalCharge { get; set; }
        
        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return (AdditionalCharge * 1.1) + base.Payment();
        }
    }
}
