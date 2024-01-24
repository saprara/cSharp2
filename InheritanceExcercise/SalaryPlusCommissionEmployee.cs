using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExcercise
{
    public class SalaryPlusCommissionEmployee : CommissionEmployee
    {
        public double salary { get; set; }
        public SalaryPlusCommissionEmployee(int Id, string name, double GrossSales,double CommissionRate,double salary)
            : base(Id,name,GrossSales,CommissionRate)
        {
            salary = this.salary;
           
        }
        public double Earnings()
        {
            return salary +base.Earnings();
        }
        public override string ToString()
        {
            return $"Id={Id}" +
                $"\nName={Name}" +
                $"\nGrossSales={GrossSales:C}" +
                $"\nCommissionRate={CommissionRate:p}\n Salary={salary:C}";


        }
    }
}
