using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProperties
{
    class Employee
    {
        public const float pi = 3.14f;
        public readonly string gender = "Male";

        public Employee()
        {
            gender = "Female";
        }

        public int EmployeeId { get; set; }

        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public int Age { get; set; }

    }
}
