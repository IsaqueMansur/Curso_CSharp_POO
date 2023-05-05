using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    internal class Program
    {
        public class Car
        {
            public string creator;
            private double velocity;

            public void ConfigVelocity(double finalVelocity)
            {
                velocity = finalVelocity;
            } 
        }
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.creator = "Jeep";
        }
    }
}
