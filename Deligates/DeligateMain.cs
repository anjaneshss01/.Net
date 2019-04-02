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
            VoidDelegate vd = new VoidDelegate(c.PrintResults); //Delegate Instantiation
            vd(); //Delegate Invocation

            CalcDelegate cd = new CalcDelegate(c.add); //Single cast Delegate Instantiation

            Console.WriteLine("-----Single Cast Delegate-----");
            cd(10, 20); //Delegate Invocation

            Console.WriteLine("\n-----MultiCast Delegate-----");
            CalcDelegate cdd = new CalcDelegate(c.add);
            cdd += new CalcDelegate(c.sub);
            cdd += new CalcDelegate(c.Mul);
            cdd += new CalcDelegate(c.Div);

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
