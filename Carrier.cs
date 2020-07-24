using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Carrier
    {
        public Vehicle[] _vehicles;

        public override string ToString()
        {
            string result = "Carrier class. vehicles on carrier: \n";
            for (int i = 0; i < _vehicles.Length; i++)
            {
                result = result + _vehicles[i].ToString() + "\n";
            }
            return result;
        }
    }
}
