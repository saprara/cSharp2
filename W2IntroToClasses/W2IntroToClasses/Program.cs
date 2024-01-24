using System.Threading.Channels;

namespace W2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 101;
            Console.WriteLine(p1.Id);
            Account savings = new Account(500);

            Console.WriteLine("Balance: "+savings.GetBalance().ToString("C"));
            savings.Deposit(200);

            Console.WriteLine("Balance: " + savings.GetBalance().ToString("C"));
            try
            {

                savings.withdraw(2000);
                Console.WriteLine("Balance: " + savings.GetBalance().ToString("C"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            AccountWithProperties a1 = new AccountWithProperties(200);
            Console.WriteLine("Balance: " + a1.Balance.ToString("C"));



        }



    }
}
