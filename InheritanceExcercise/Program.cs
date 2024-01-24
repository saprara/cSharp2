namespace InheritanceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee commEmpl = new CommissionEmployee(101,"John",10000,0.15);
            Console.WriteLine(commEmpl);
            Console.WriteLine($"\nEarnings = {commEmpl.Earnings():C}\n\n");

            SalaryPlusCommissionEmployee salCommEmmpl = new SalaryPlusCommissionEmployee(102, "Anne", 10000, 0.10, 800);
            Console.WriteLine(salCommEmmpl);
            Console.WriteLine($"\nEarnings = {salCommEmmpl.Earnings():C}\n\n");

        }
    }
}
