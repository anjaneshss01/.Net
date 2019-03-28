using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoWheeler twoWheeler = new TwoWheeler(2, 2, "DTSI");
            twoWheeler.GearType();

            Console.Read();

            //Parent p = new Parent();
            //p.Method1();
            //p.Method2();

            //Child ch = new Child();
            //ch.Method1();
            //ch.Method2();
            //ch.Method3();
            //ch.Method4();
            
            //GrandParent pp = new Child();
            //pp.Method0();
            //pp.Method00();


            //Child chh = (Child)p;
            //chh.Method00();
            //ch.Method4();

            //string 

            //Console.Read();
        }
    }
}
