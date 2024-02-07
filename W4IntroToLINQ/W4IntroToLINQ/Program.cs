namespace W4IntroToLINQ
{
    internal class Program
    {
        public static object ConsoleTable { get; private set; }

        static void Main(string[] args)
        {
           /* int[] array = {4,5,33,6,5,3,2,6,6,7,76,3,3,1,789,8,5,42 };
            //query syntax
            Console.WriteLine("query syntax\n\n");
           /* var GreaterThan4 = from n in array
                               where n > 4
                               orderby n descending
                               select n;
            foreach(var c in GreaterThan4)
            {
                Console.WriteLine(c);
            }
           */
            //method syntax
            /*Console.WriteLine("\n\n Method syntax\n\n");
            var greaterThan4 = array.Where(n => n > 4).OrderByDescending(n=>n);
            foreach (var c in greaterThan4)
            {
                Console.Write("\t"+c);
            }
            Console.WriteLine("\n");




            List<string> colors = new List<string>();
            colors.Add("RuSt");
            colors.Add("GreEn");
            colors.Add("BluE");
            colors.Add("rEd");
            colors.Add("piNK");
            var StartWithR = from c in colors
                             let uppercaseColors = c.ToUpper()
                             where uppercaseColors.StartsWith("R")
                             orderby uppercaseColors
                             select uppercaseColors;

            colors.Add("RubY");

            foreach( var i in StartWithR)
            {
                Console.WriteLine(i+"\n");
            }*/

            List<Employee> employees = new List<Employee>()
            {
                new Employee("John","Harding",50000),
                new Employee("Jon","Harding",55000),
                new Employee("Athif","Green",25000),
                new Employee("John","Green",65000),
                new Employee("Jon","Indigo",70000),
                new Employee("frenchy","Indigo",80000)

            };
            var allEmps = from emp in employees
                          select emp;
            foreach( var e in allEmps)
            {
                Console.WriteLine(e);
            }
            var btw25kTo55k= from emp in employees
                             where emp.Salary >=25000 && emp.Salary <=55000
                             select emp;
            Console.WriteLine(" ");

            foreach (var e in btw25kTo55k)
            {
                Console.WriteLine(e);
            }
            var SalEmp =employees.Where(e=>e.Salary>50000)
                .ToList();
            foreach (var e in SalEmp)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(" ");
            var sortEmps= from emp in employees
                          orderby emp.lastName, emp.firstName
                          select emp;

            foreach (var e in sortEmps)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(" ");
            var lastnames=( from emp in employees
                           select emp.lastName).Distinct();
            //nsoleTable table = new ConsoleTable();
            foreach (var e in lastnames)
            {
                Console.WriteLine(e);
            }
            var empFNLN = from emps in employees select new { emps.firstName, emps.lastName };
            foreach (var e in empFNLN)
            {
                Console.WriteLine(e);
            }

        }
    }
}
