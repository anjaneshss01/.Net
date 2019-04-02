using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDeligate
{
    public delegate void CalcDelegate(int a, int b); // Deligate Declaration

    public class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("The Sum is {0}", a + b);
        }

        public void Sub(int a,int b)
        {
            Console.WriteLine("The Difference is {0}", a - b);
        }

        public void Mul(int a,int b)
        {
            Console.WriteLine("The Product is {0}", a * b);
        }

        public void Div(int a,int b)
        {
            Console.WriteLine("The Division is {0}", a / b);
        }
    }
}
