using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Motorcycle : Vehicle
    {
        //Data
        public int _NumberOfHandBreakes;
        internal new string _model;
        internal new int _numberOfWheels;

       

        public override int GetMaxNumOfPassengers()
        {
            return 2; ;
        }

       

        public override int GetMaxSpeed()
        {
            return 180; ;
        }

        public override string ToString()
        {
            return "$ Motorcycle [NumberOfHandBreakes]:{ _NumberOfHandBreakes} + base.ToString()";
        }
    }
}
