namespace W1CSharpFundamental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;
           //string b = "hourly";
           // Console.WriteLine($"this guy is payed $ {a} as {b}");
            //String[] colors = { "orange", "red", "yellow", "blue" };
            //foreach(var c in colors)
            {
                Console.WriteLine($"{c,100}");
            }
            double abc = 5.55555;
            Console.WriteLine(abc.ToString("C"));
            double rate = 0.25;
            Console.WriteLine(rate.ToString("P"));
            double v = 454554.343553;
            Console.WriteLine(v.ToString("f2"));
            double n = 132324574744;
            Console.WriteLine(n.ToString("N"));*/
            Console.Write("enter the subtotal");

            double subtotal =double.Parse( Console.ReadLine());
            Console.Write("enter the discount %");
            double discount = double.Parse(Console.ReadLine());
            Console.WriteLine("subtotal : " +subtotal);
            Console.WriteLine("discount % :" + (discount/100).ToString("P"));

            double Discountedprice = subtotal * (discount / 100);
            double total = subtotal - Discountedprice;
            Console.WriteLine(Discountedprice.ToString("c"));
            Console.WriteLine(total.ToString("C"));





        }
    }
}
