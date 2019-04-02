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
            CalcDeligate cd = new CalcDeligate(c.add);

            cd.BeginInvoke(10,20);
        }

        //static void GetNumber()
        //{
        //    Console.WriteLine("Enter the 2 numbers");
        //    int a = Convert.ToInt16(Console.ReadLine());
        //    int b = Convert.ToInt16(Console.ReadLine());
        //}
    }
}
