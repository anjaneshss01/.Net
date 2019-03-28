using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract
{
    public abstract class AbsCRUD
    {
        public abstract void Save();

        public abstract void Update();

        public abstract void GetById(int id);

        public abstract void GetAll();

        public abstract void Delete(int id);


        public void DisplayMessage(string msg)
        {
            Console.WriteLine("The record has been {0} Successfully", msg);
        }

    }

    public abstract class abs2
    { }

    public class ImplementAbstractClass : AbsCRUD
    {
        public override void Delete(int id)
        {
            DisplayMessage("Deleted");
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            DisplayMessage("Saved");
        }

        public override void Update()
        {
            DisplayMessage("Updated");
        }
    }
}
