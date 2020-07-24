using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Car : Vehicle
    {
        public int _numberOfDoors;
        public new int _numberOfWheels;
        public new string _model;


       

        public override int GetMaxNumOfPassengers()
        {
            return 5; ;
        }

      
        public override int GetMaxSpeed()
        {
            return 220; ;
        }

        public override string ToString()
        {
            return "$ Car [numberOfDoors]:{_numberOfDoors} + base.ToString()";
        }
    }
}
