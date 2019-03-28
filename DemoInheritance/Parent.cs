using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class GrandParent
    {
        public void Method0() { Console.WriteLine("Method0 invoked"); }
        public void Method00() { Console.WriteLine("Method00 invoked"); }
    }
    class Parent : GrandParent
    {
        public void Method1() { Console.WriteLine("Method1 invoked"); }
        public void Method2() { Console.WriteLine("Method2 invoked"); }
        private void Method22() { Console.WriteLine("Method2 invoked"); }
        protected void Method222() { Console.WriteLine("Method222 invoked"); }
    }

    class Child : Parent
    {
        public void Method3() { Console.WriteLine("Method3 invoked"); }
        public void Method4() { Console.WriteLine("Method4 invoked");
            Method222();
        }
    }
}
