using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphishm
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("The Addition is : " +  a + b);
        }

        public void Add(string a, string b)
        {
            Console.WriteLine("The Addition is : " + a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine("The Addition is : " + a + b);
        }

        public void Add(int a, string b)
        {
            Console.WriteLine("The Addition is : " + a.ToString() + b);
        }

        public void Add(string a, int b)
        {
            Console.WriteLine("The Addition is : ", a + b.ToString());
        }
    }
}
