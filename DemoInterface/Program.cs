using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            ICR cR = new Employee();


            Invoice invoice = new Invoice();

            ICR cR1 = new Invoice();


            ICRUD cRUD = new Invoice();


            ImplementCalculator implementCalculator = new ImplementCalculator();
            implementCalculator.Add(12, 45);

            ICalc2 calc2 = new ImplementCalculator();
            calc2.Add(23, 56);

            Console.Read();
            
        }
    }
}
