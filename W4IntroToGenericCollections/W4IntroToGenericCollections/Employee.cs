using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4IntroToGenericCollections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int id,string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;    
        }
        public override string ToString()
        {
            return $"Employee Id : {Id}\nEmployee Name: {Name}\nEmployee Salary : {Salary:C}\n\n\n";
        }
    }
}
