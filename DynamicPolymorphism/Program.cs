using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            ch.Singer();

            Father father = new Child();
            father.Singer();

            ch.Chef();
            father.Chef();

            Console.Read();


        }
    }
}
