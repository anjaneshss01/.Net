using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    interface ICalc1
    {
        void Add(int a, int b);

        void Sub(int a, int b);

        void Mul(int a, int b);

        void Div(int a, int b);
    }

    interface ICalc2
    {
        void Add(int a, int b);
        void Sin();
    }


    class ImplementCalculator : ICalc1, ICalc2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Added Successfully ICalc1");
        }

        public void Div(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Mul(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void Sub(int a, int b)
        {
            throw new NotImplementedException();
        }

        void ICalc2.Add(int a, int b)
        {
            Console.WriteLine("Added Successfully ICalc2");
        }

        public void Sin()
        {
            throw new NotImplementedException();
        }
    }
}
