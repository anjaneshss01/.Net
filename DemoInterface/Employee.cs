using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Employee : ICR
    {
        public void GetAll()
        {
           
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    class Student : IUD
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class Base { }
    class Child { }

    class Invoice : Base, ICR, IUD
    {
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            Console.WriteLine("Record Saved Successfully");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Record Deleted Successfully");
        }

        public void Update()
        {
            Console.WriteLine("Record Updated Successfully");
        }
    }
}
