using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //Employee.pi = 4;
            float ff = Employee.pi;

            emp.EmployeeId = 123;
            emp.EmployeeName = "Ravi";
            emp.Age = 35;

            Console.WriteLine("Employee Id is :{0} ", emp.EmployeeId);
            Console.WriteLine("Employee Name is :, {0}", emp.EmployeeName);
            Console.WriteLine("Employee Age is :, {0}", emp.Age);

            Console.Read();
        }
    }
}
