using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            IVehicle plane = new Plane();
            car.PowerOn();
            plane.PowerOn();

            Console.ReadKey();
        }
    }
}
