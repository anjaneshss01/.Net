using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    public delegate void CalcDelegate(int a, int b); //Delegate Declaration
    public delegate void VoidDelegate();
    class Calculator
    {
        //public int a = 0;
        //public int b = 0;

        public void add(int a, int b)
        {
            Console.WriteLine("The Sum is {0}", a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("The Difference is {0}", a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("The Product is {0}", a * b);
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("The Division is {0}", a / b);
        }

        public void PrintResults()
        {
            Console.WriteLine("The Results are:");
        }
    }
}
