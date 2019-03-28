using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementAbstractClass implementAbstractClass = new ImplementAbstractClass();
            implementAbstractClass.Save();
            implementAbstractClass.Update();

            Console.Read();
        }
    }
}
