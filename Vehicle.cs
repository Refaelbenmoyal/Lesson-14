using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class Vehicle
    {
        //Data
        public int _numberOfWheels;
        public string _model;

        //functionallty
        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return "$ Vehice [numberOfWheels]:{_numberOfWheels} [model]:{_model} [GetMaxNumOfPassengers]:{GetMaxNumOfPassengers} [GetMaxSpeed]:{GetMaxSpeed} ";
        }
    }
}
