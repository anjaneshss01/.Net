using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDeligate
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            CalcDelegate cd = new CalcDelegate(c.Add); // SingleCast Deligate Instantition

            cd += new CalcDelegate(c.Sub); // Multicast Deligate
            cd += new CalcDelegate(c.Mul);
            
            cd(0,3); // Deligate Invocations

            Console.WriteLine("----------------New Deligate with Division----------------");
            CalcDelegate cdd = new CalcDelegate(c.Div);
            cdd(20, 10);

            Console.Read();
        }
    }
}
