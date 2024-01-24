using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3IntroToInheritance
{
    class BaseClass
    {
        private int p;
        protected int q;
        public int r;
    }
    class DerivedClass : BaseClass
    {
        public void MyMethod()
        {
            r = 10;
            q = 10;
        }
    }

    internal class AccessModifers
    {
        public void method1()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.r = 10;
        }
    }
}
