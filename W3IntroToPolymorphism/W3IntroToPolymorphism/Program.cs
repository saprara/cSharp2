namespace W3IntroToPolymorphism
{


    class BaseClass
    {
        public  void Show()
        {
            Console.WriteLine("base class show method");
        }
    }
    class DerivedClass : BaseClass
    {
        public  void Show()
        {
            Console.WriteLine("derived class show method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objbase;
            objbase = new BaseClass();
            objbase=new DerivedClass();
            objbase.Show();

            
        }
    }
}
