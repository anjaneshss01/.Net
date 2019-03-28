using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionHandling
{
    class Calculator
    {
        public void Divide()
        {
            int a = 10, b = 0, result = 0;

            if (b > 0)
                result = a / b; 
        }
    }
}
