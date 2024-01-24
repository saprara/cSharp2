using System;

namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SalariedEmployee sm = new SalariedEmployee(101, "john", 1000);
             Console.WriteLine(sm);
             Console.WriteLine($"\nEarning = {sm.Earnings():C}\n\n");

             HourlyEmployee he = new HourlyEmployee(102, "Emma", 50, 17);
             Console.WriteLine(he);
             Console.WriteLine($"\nEarning = {he.Earnings():C}\n\n");

             CommissionEmployee ce = new CommissionEmployee(103, "Emily", 10000, 0.25);
             Console.WriteLine(ce);
             Console.WriteLine($"\nEarning = {ce.Earnings():C}\n\n"); */




            /*  Employee emp;
              emp= new SalariedEmployee(101, "john", 1000);
              Console.WriteLine(emp);
              Console.WriteLine($"\nEarning = {emp.Earnings():C}\n\n");



              emp = new HourlyEmployee(102, "Emma", 50, 17);
              Console.WriteLine(emp);
              Console.WriteLine($"\nEarning = {emp.Earnings():C}\n\n");


              emp = new CommissionEmployee(103, "Emily", 10000, 0.25);
              Console.WriteLine(emp);
              Console.WriteLine($"\nEarning = {emp.Earnings():C}\n\n"); */




            Employee[] employees = new Employee[3]
            {
                new SalariedEmployee(101, "john", 1000),
                 new HourlyEmployee(102, "Emma", 50, 17),
                  new CommissionEmployee(103, "Emily", 10000, 0.25)
        };
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"\nEarning = {emp.Earnings():C}\n\n");

            }

        }
    }
}
