using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3IntroToInheritance
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("parent class constructor called");
        }
        public ParentClass(string message)
        {
            Console.WriteLine("parent class constructor called "+message);
        }
    }
    class ChildClass : ParentClass
    {
        public ChildClass(): base("hello")
        {
            Console.WriteLine("child class constructor called");
        }
    }


    internal class ConstructorCalls
    {



    }
}
