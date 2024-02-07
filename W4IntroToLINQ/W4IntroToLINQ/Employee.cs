using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4IntroToLINQ
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public  double Salary { get; set; }
        public Employee(string fname, string lname, double salary)
        {
            firstName = fname;
            lastName = lname;   
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{firstName,-10} | {lastName,-10} | {Salary,10:C}";
        }

    }
}
