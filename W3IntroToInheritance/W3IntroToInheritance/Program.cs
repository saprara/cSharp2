namespace W3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Rectangle rectangle = new Rectangle();
            rectangle.name = "rectangle";
            rectangle.length = 10;
            rectangle.width = 20;
            Console.WriteLine("the shape is "+ rectangle.name);
            Console.WriteLine("the area is "+rectangle.getArea());

            Circle circle = new Circle()
            {
                name="circle",r = 10


            };
            
            Console.WriteLine("\n\nthe shape is "+circle.name);
            Console.WriteLine("the area is "+circle.getArea());
            */
           ParentClass parentClass = new ParentClass("hello");
            ChildClass childClass = new ChildClass(); 
            
        }






    }
}
