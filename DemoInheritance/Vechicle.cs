using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Vechicle
    {
        int typres = 0;
        string engine = string.Empty;
        string seatType = string.Empty;
        string breaks = string.Empty;

        public Vechicle(int tyre, string engine)
        {
            this.typres = tyre;
            this.engine = engine;
        }
    }

    class TwoWheeler : Vechicle
    {
        int mirror = 0;
        public TwoWheeler(int mirror, int tyre, string engine) : base(tyre, engine)
        {
            this.mirror = mirror;
        }

        public void GearType()
        {
        }
    }

    //class FourWheeler : Vechicle
    //{
    //    public FourWheeler()
    //    {

    //    }
    //}

    //class EightWheeler : Vechicle
    //{

    //}
}
