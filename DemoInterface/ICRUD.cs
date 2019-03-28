using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public interface ICR
    {
        void Save();

        void GetById(int id);

        void GetAll();

    }

    public interface IUD
    {
        void Update();
        void Delete(int id);
    }

    public interface ICRUD : ICR, IUD
    {

    }
}
