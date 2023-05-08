using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bike = new Bicycle();
            Car car = new Car();

            car.Run();
            bike.Run();

            Console.ReadKey();
        }
    }
}
