using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3IntroToInheritance
{
    public class Shape
    {
        public string name { get; set; }
    }





    class Rectangle : Shape {
        public double length { get; set; }
        public double width { get; set; }
        public double getArea()
        {
            return length * width;
        }
    }





        class Circle : Shape {

            public double r { get; set; }
            public double getArea()
            {
            return Math.PI * r * r;
            }






        }




    }
   

