using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates
{
    class DeligateMain
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            CalcDeligate cd = new CalcDeligate(c.add); //Single cast Delegate Instantiation

            Console.WriteLine("-----Single Cast Delegate-----");
            cd(10, 20); //Delegate Invocation

            Console.WriteLine("\n-----MultiCast Delegate-----");
            CalcDeligate cdd = new CalcDeligate(c.add);
            cdd += new CalcDeligate(c.sub);
            cdd += new CalcDeligate(c.Mul);
            cdd += new CalcDeligate(c.Div);

            cdd(20, 2);

            Console.Read();

        }

        //static void GetNumber()
        //{
        //    Console.WriteLine("Enter the 2 numbers");
        //    int a = Convert.ToInt16(Console.ReadLine());
        //    int b = Convert.ToInt16(Console.ReadLine());
        //}
    }
}
