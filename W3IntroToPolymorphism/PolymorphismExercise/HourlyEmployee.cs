using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class HourlyEmployee : Employee
    {
        public int Hours { get; set; }
        public double Wage { get; set; }
        public HourlyEmployee(int Id, string Name, int hours, double wage) : base(Id, Name)
        {
            Hours = hours;
            Wage = wage;
        }

        public override double Earnings()
        {
            if (Hours <= 40)
            {
                return Hours * Wage;
            }
            else
            {
                return (40 * Wage) + ((Hours - 40) * (Wage * 1.5));
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nHours = {Hours}\n Wage = {Wage:C}";

        }
    }
}
