using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Father
    {
        public void Singer()
        {
            Console.WriteLine("I am not a professional singer");
        }

        public virtual void Chef()
        {
            Console.WriteLine("I am not a professional Chef");
        }
    }

    class Child : Father
    {
        public new void Singer() //Declaration
        { // Definition
            Console.WriteLine("I am a professional singer");
        }

        public override void Chef()
        {
            Console.WriteLine("I am a professional Chef");
        }


        interface I1
        {
            void Add();
        }

        abstract class absClass
        {
            public abstract void Add();

            public void Print()
            { }
        }
    }
}
