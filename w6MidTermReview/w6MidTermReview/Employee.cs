using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w6MidTermReview
{
    class Employee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string City  { get; set; }
        public Employee(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
