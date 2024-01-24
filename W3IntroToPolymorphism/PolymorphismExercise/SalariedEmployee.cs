using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public  class SalariedEmployee : Employee
    {
        public double WeeklySalary { get; set; }
        public SalariedEmployee(int Id,string Name,double weeklySalary): base(Id,Name)
        {
            WeeklySalary = weeklySalary;
        }
        public override double Earnings()
        {
            return WeeklySalary;
        }
        public override string ToString()
        {
            return base.ToString() +$"\n Weekly Salary = {WeeklySalary:C}";
        }
    }
}
