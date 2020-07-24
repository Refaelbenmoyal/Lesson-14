using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        

        static void PrintVehilce(Vehicle v)
        {
            Console.WriteLine(v._model);
            Console.WriteLine(v);
        }
        static void PrintVehicleArray(Vehicle[] arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Car Toyota = new Car()
            {
                _model = "2018",
                _numberOfDoors = 5,
                _numberOfWheels = 4,
            };
            Car Mazda = new Car()
            {
                _model = "2020",
                _numberOfDoors = 5,
                _numberOfWheels = 4,
            };
            Motorcycle Honda = new Motorcycle()
            {
                _model = "2018",
                _NumberOfHandBreakes = 2,
                _numberOfWheels = 2,
            };
            Motorcycle Yamaha = new Motorcycle()
            {
                _model = "2020",
                _NumberOfHandBreakes = 2,
                _numberOfWheels = 2,
            };
            Vehicle[] vehicles = new Vehicle[] {Honda, Mazda, Toyota };





        }
    }
}
