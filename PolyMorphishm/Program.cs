using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphishm
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(12, 34);
            calc.Add(34, 56, 78);
            calc.Add("WElcome", "Dotnet");

            Console.Read();
        }
    }
}
